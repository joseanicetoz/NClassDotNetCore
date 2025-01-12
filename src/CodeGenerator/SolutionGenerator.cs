// NClass - Free class diagram editor
// Copyright (C) 2006-2009 Balazs Tihanyi
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

using NClass.Core;
using NClass.Translations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace NClass.CodeGenerator;

public abstract class SolutionGenerator
{
    private readonly Project project;
    private readonly List<ProjectGenerator> projectGenerators = new List<ProjectGenerator>();

    /// <exception cref="ArgumentNullException">
    /// <paramref name="project"/> is null.
    /// </exception>
    protected SolutionGenerator(Project project)
    {
        this.project = project ?? throw new ArgumentNullException(nameof(project));
    }

    public string SolutionName
    {
        get { return project.Name; }
        set {  project.Name = value; }
    }

    protected Project Project
    {
        get { return project; }
    }

    protected List<ProjectGenerator> ProjectGenerators
    {
        get { return projectGenerators; }
    }

    /// <exception cref="ArgumentException">
    /// <paramref name="location"/> contains invalid path characters.
    /// </exception>
    internal GenerationResult Generate(string location)
    {
        GenerationResult result = CheckDestination(location);
        if (result != GenerationResult.Success)
            return result;

        if (!GenerateProjectFiles(location))
            return GenerationResult.Error;
        if (!GenerateSolutionFile(location))
            return GenerationResult.Error;

        return GenerationResult.Success;
    }

    private GenerationResult CheckDestination(string location)
    {
        try
        {
            location = Path.Combine(location, SolutionName);
            if (Directory.Exists(location))
            {
                DialogResult result = MessageBox.Show(
                    Strings.CodeGenerationOverwriteConfirmation, Strings.Confirmation,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                    return GenerationResult.Success;
                else
                    return GenerationResult.Cancelled;
            }
            else
            {
                Directory.CreateDirectory(location);
                return GenerationResult.Success;
            }
        }
        catch
        {
            return GenerationResult.Error;
        }
    }

    private bool GenerateProjectFiles(string location)
    {
        bool success = true;
        location = Path.Combine(location, project.Name);

        projectGenerators.Clear();
        foreach (IProjectItem projectItem in project.Items)
        {

            if (projectItem as Model != null)
            {
                ProjectGenerator projectGenerator = CreateProjectGenerator(projectItem as Model);
                projectGenerators.Add(projectGenerator);

                try
                {
                    projectGenerator.Generate(location);
                }
                catch (FileGenerationException)
                {
                    success = false;
                }
            }
        }

        return success;
    }

    /// <exception cref="ArgumentException">
    /// The <paramref name="model"/> is invalid.
    /// </exception>
    protected abstract ProjectGenerator CreateProjectGenerator(Model model);

    protected abstract bool GenerateSolutionFile(string location);
}