namespace ReadingFilesTask
{
    public static class FileManager
    {
        /// <summary>
        /// Подсчёт кол-ва пробелов в текстовом файле
        /// </summary>
        /// <param name="filePath"></param>
        public static void CountSpacesInFile(string filePath)
        {
            var fileText = File.ReadAllText(filePath);
            var fileInfo = new FileInfo(filePath);

            if (string.IsNullOrWhiteSpace(fileText) || string.IsNullOrEmpty(fileText))
            {
                ConsoleManager.PrintZeroResult(fileInfo.Name);
            }
            else
            {
                var spaceCount = fileText.Count(t => char.IsWhiteSpace(t));
                ConsoleManager.PrintResult(fileInfo.Name, spaceCount);
            }
        }
    }
}
