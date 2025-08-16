using System.IO;

namespace Il2CppDumper {
    public static class DummyAssemblyExporter {
        public static void Export(Il2CppExecutor il2CppExecutor, string outputDir, bool addToken) {
            if (Directory.Exists(outputDir))
                Directory.Delete(outputDir, true);//we need delete all older files here
            Directory.CreateDirectory(outputDir);
            Directory.SetCurrentDirectory(outputDir);
            var dummy = new DummyAssemblyGenerator(il2CppExecutor, addToken);
            foreach (var assembly in dummy.Assemblies) {
                using var stream = new MemoryStream();
                assembly.Write(stream);
                File.WriteAllBytes(assembly.MainModule.Name, stream.ToArray());
            }
        }
    }
}
