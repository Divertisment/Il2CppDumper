added work_dir and same path to files...
 ```csharp [STAThread]
 static void Main(string[] args) {
     config = JsonSerializer.Deserialize<Config>(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"config.json"));
     var work_dir = @"D:\AO Nix\";
     var il2cppPath = work_dir+"GameAssembly.so";
     var metadataPath = work_dir+"global-metadata.dat";
     var outputDir = work_dir+ "AO_dump";```
