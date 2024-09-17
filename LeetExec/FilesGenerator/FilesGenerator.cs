namespace LeetExec;

public class FilesGenerator
{
    public static void GenerateFiles(string problemName, string parameters, string returns)
    {
        var workingDirectory = Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..", "..", "LeetLib");
        var path = Path.Combine(workingDirectory, $"{problemName}");

        if (Directory.Exists(path))
        {
            Directory.Delete(path, true);
        }

        Directory.CreateDirectory(path);
        
        var problemShortName = problemName.Split(' ').Skip(1).Aggregate((a, b) => a + b);
        
        // load template
        var templatePath = Path.Combine(Directory.GetCurrentDirectory(), "FilesGenerator", "BaseTemplate.txt");
        var template = File.ReadAllText(templatePath);
        
        template = template.Replace("{name}", problemShortName);
        template = template.Replace("{parameters}", parameters);
        template = template.Replace("{returns}", returns);
        
        // write into directory
        var baseFilePath = Path.Combine(path, $"{problemShortName}Base.cs");
        File.WriteAllText(baseFilePath, template);
        
        // load exec template
        var execTemplatePath = Path.Combine(Directory.GetCurrentDirectory(), "FilesGenerator", "ExecTemplate.txt");
        var execTemplate = File.ReadAllText(execTemplatePath);
        
        execTemplate = execTemplate.Replace("{name}", problemShortName);
        execTemplate = execTemplate.Replace("{fullName}", problemName);
        execTemplate = execTemplate.Replace("{returns}", returns);

        // write into directory
        var execFilePath = Path.Combine(path, $"{problemShortName}Exec.cs");
        File.WriteAllText(execFilePath, execTemplate);
        
        // load test template
        var v1TemplatePath = Path.Combine(Directory.GetCurrentDirectory(), "FilesGenerator", "V1Template.txt");
        var v1Template = File.ReadAllText(v1TemplatePath);
        
        v1Template = v1Template.Replace("{name}", problemShortName);
        v1Template = v1Template.Replace("{parameters}", parameters);
        v1Template = v1Template.Replace("{returns}", returns);
        
        // write into directory
        var v1FilePath = Path.Combine(path, $"{problemShortName}V1.cs");
        File.WriteAllText(v1FilePath, v1Template);
    }
}