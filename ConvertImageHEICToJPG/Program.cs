using ImageMagick;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Conversor de HEIC para JPG");
        Console.WriteLine("==========================");

        // Solicita o caminho da pasta de entrada
        Console.Write("Digite o caminho da pasta com as imagens HEIC: ");
        string inputFolder = Console.ReadLine();

        // Solicita o caminho da pasta de saída
        Console.Write("Digite o caminho da pasta para salvar os JPGs: ");
        string outputFolder = Console.ReadLine();

        // Verifica se as pastas existem
        if (!Directory.Exists(inputFolder))
        {
            Console.WriteLine("Pasta de entrada não encontrada!");
            return;
        }

        // Cria a pasta de saída se não existir
        if (!Directory.Exists(outputFolder))
        {
            Directory.CreateDirectory(outputFolder);
        }

        try
        {
            // Obtém todos os arquivos HEIC da pasta (tanto maiúsculos quanto minúsculos)
            var heicFiles = Directory.GetFiles(inputFolder, "*.heic")
                           .Concat(Directory.GetFiles(inputFolder, "*.HEIC"))
                           .ToArray();

            Console.WriteLine($"\nEncontrados {heicFiles.Length} arquivos HEIC");

            foreach (string heicFile in heicFiles)
            {
                try
                {
                    string fileName = Path.GetFileNameWithoutExtension(heicFile);
                    string jpgPath = Path.Combine(outputFolder, fileName + ".jpg");

                    // Usa ImageMagick para converter
                    using (var image = new MagickImage(heicFile))
                    {
                        // Define a qualidade do JPG (0-100)
                        image.Quality = 95;

                        // Salva como JPG
                        image.Write(jpgPath, MagickFormat.Jpg);
                    }

                    Console.WriteLine($"Convertido: {fileName}.heic -> {fileName}.jpg");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao converter {Path.GetFileName(heicFile)}: {ex.Message}");
                }
            }

            Console.WriteLine("\nConversão concluída!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}