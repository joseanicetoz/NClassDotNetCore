// NClass - Free class diagram editor
// Copyright (C) 2006-2009 Balazs Tihanyi
// 
// NClass.GUI.LanguageManager
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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using NClass.Core.EventArgs;

namespace NClass.Core;

public class LanguageManager
{
    private static readonly LanguageManager instance = new LanguageManager();

    private List<Language> languages = new List<Language>();

    public List<Language> Languages
    {
        get
        {
            if (languages == null) LoadLanguages();
            return languages;
        }
    }

    public EventHandler<NClassEventArgs> OnError { get; set; }

    public static LanguageManager Instance
    {
        get { return instance; }
    }

    public Language GetLanguage(string name)
    {
        if (languages.Count < 1)
            LoadLanguages();

        return languages?.Find(o => o.Name.Equals(name));
    }

    private void LoadLanguages()
    {
        try
        {
            languages.Clear();
            
            string execPath = Environment.CurrentDirectory;

            DirectoryInfo directory = new DirectoryInfo(execPath);

            foreach (FileInfo file in directory.GetFiles("*.dll"))
            {
                Assembly assembly = Assembly.LoadFile(file.FullName);
                LoadLanguage(assembly);
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

    private void LoadLanguage(Assembly assembly)
    {
        try
        {
            foreach (Type type in assembly.GetTypes())
            {
                if (!type.IsSubclassOf(typeof(Language))) continue;
#if DEBUG
                Debug.WriteLine(">>> Found language! " + type.Name);
#endif
                Language language = (Language)Activator.CreateInstance(type);
                languages.Add(language);
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
