// NClass - Free class diagram editor
// Copyright (C) 2006-2009 Balazs Tihanyi
// 
// NClass.GUI.PlugInManager
// Copyright (C) 2021 Jose Aniceto
//
// This program is free software; you can redistribute it and/or modify it under 
// the terms of the GNU General Public License as published by the Free Software 
// Foundation; either version 3 of the License, or (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful, but WITHOUT 
// ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS 
// FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License along with 
// this program; if not, write to the Free Software Foundation, Inc., 
// 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA

using NClass.DiagramEditor;
using NClass.Shared;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace NClass.GUI
{
    public class PlugInManager
    {
        public DocumentManager DocumentManager { get; set; }

        public List<Plugin> PlugIns { get; set; } = new List<Plugin>();

        public EventHandler<NClassEventArgs> OnError { get; set; }

        public void LoadPlugins()
        {
            try
            {
                string pluginsPath = Path.Combine(Application.StartupPath, "Plugins");
                if (!Directory.Exists(pluginsPath))
                    return;

                DirectoryInfo directory = new DirectoryInfo(pluginsPath);

                foreach (FileInfo file in directory.GetFiles("*.dll"))
                {
                    Assembly assembly = Assembly.LoadFile(file.FullName);
                    LoadPlugin(assembly);
                }
            }
            catch (Exception ex)
            {
#if DEBUG
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
#endif
                OnError?.Invoke(this, new NClassEventArgs { Message = ex.Message });
            }
        }

        private void LoadPlugin(Assembly assembly)
        {
            try
            {
                foreach (Type type in assembly.GetTypes())
                {
                    if (type.IsSubclassOf(typeof(Plugin)))
                    {
                        NClassEnvironment environment =
                            new NClassEnvironment(Workspace.Default, DocumentManager);
                        Plugin plugin = (Plugin)Activator.CreateInstance(type, environment);
                        PlugIns.Add(plugin);
                    }
                }
            }
            catch (Exception ex)
            {
#if DEBUG
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
#endif
                OnError?.Invoke(this, new NClassEventArgs { Message = assembly.FullName + "\n" + ex.Message });
            }
        }
    }
}
