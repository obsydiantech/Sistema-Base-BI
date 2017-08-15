using System;
using System.IO;

namespace Sistema_Base_BI.Managers
{
    public class FileManager
    {
        // |---------------Atributos---------------|
        private static FileManager instance;
        public static FileManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new FileManager();

                return instance;
            }
        }
        private StreamWriter streamWriter;
        private StreamReader streamReader;

        // |---------------Constructores---------------|
        private FileManager()
        {

        }

        // |---------------Métodos Públicos---------------|
        public Boolean Init()
        {
            return true;
        }

        public String ReadFile(String fillePath)
        {
            String text = "";

            try
            {
                streamReader = new StreamReader(fillePath);
                streamReader.ReadToEnd();
                streamReader.Close();
            }
            catch (IOException e)
            {
                streamReader.Close();
            }

            return text;
        }

        public Boolean WriteFile(String fillePath, String text)
        {
            try
            {
                streamWriter = new StreamWriter(fillePath, true);
                streamWriter.WriteLine(text);
                streamWriter.Close();

                return true;
            }
            catch (IOException e)
            {
                streamWriter = new StreamWriter(NamesPathsManager.Instance.ERROR_LOGS_FILEPATH, true);
                streamWriter.Write(text);
                streamWriter.Close(); 

                return false;
            }
        }

        public Boolean FileExists(String fillePath)
        {
            return File.Exists(fillePath);
        }

        // |---------------Métodos Privados---------------|
    }
}
