using System.Text;

namespace LeetExec;

public class GenData
{
    public string Name;
    public (string, string)[] Parameters;
    public string Returns;
}

public class FilesGenerator
{
    private static string Slugify(string name)
    {
        // replace special characters with _
        var sb = new StringBuilder();
        foreach (var c in name)
        {
            if (c != '\'')
            {
                sb.Append(c);
            }
            else
            {
                sb.Append('_');
            }
        }
        return sb.ToString();
    }
    public static void GenerateFiles(GenData data)
    {
        var problemName = Slugify(data.Name);
        var returns = data.Returns;
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
        template = template.Replace("{parameters}", string.Join(", ", data.Parameters.Select(p => $"{p.Item1} {p.Item2}")));
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
        execTemplate = execTemplate.Replace("{arguments}", string.Join(", ", data.Parameters.Select(p => $"testCase.{p.Item2}")));
        execTemplate = execTemplate.Replace("{parameters}", string.Join(Environment.NewLine, data.Parameters.Select(p => $" public {p.Item1} {p.Item2};")));

        // write into directory
        var execFilePath = Path.Combine(path, $"{problemShortName}Exec.cs");
        File.WriteAllText(execFilePath, execTemplate);
        
        // load test template
        var v1TemplatePath = Path.Combine(Directory.GetCurrentDirectory(), "FilesGenerator", "V1Template.txt");
        var v1Template = File.ReadAllText(v1TemplatePath);
        
        v1Template = v1Template.Replace("{name}", problemShortName);
        v1Template = v1Template.Replace("{parameters}", string.Join(", ", data.Parameters.Select(p => $"{p.Item1} {p.Item2}")));
        v1Template = v1Template.Replace("{returns}", returns);
        
        // write into directory
        var v1FilePath = Path.Combine(path, $"{problemShortName}V1.cs");
        File.WriteAllText(v1FilePath, v1Template);
    }
}