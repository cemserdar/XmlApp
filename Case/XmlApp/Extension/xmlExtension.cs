namespace XmlApp.Extension
{
    public static class xmlExtension
    {

        public static bool IsXml(this IFormFile file)
        {
            var splittedName = file.FileName.Split('.');
            if (splittedName.Length < 2 || splittedName[splittedName.Length - 1].ToLower() != "xml")
                return false;
            return true;
        }
    }

}