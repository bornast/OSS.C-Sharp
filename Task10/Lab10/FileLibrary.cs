using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;

namespace Labs
{
    public static class FileLibrary
    {
        private static void CreateFileIfDoesntExists(string path)
        {
            if (!File.Exists(path))
            {
                FileStream stream = File.Create(path);
                stream.Close();

            }
        }

        public static void SerializeObjectToFile(object objectToSerialize, string path)
        {
			CreateFileIfDoesntExists(path);

			FileStream stream = new FileStream(path, FileMode.Open);

			SoapFormatter formatter = new SoapFormatter();

			try
			{
				formatter.Serialize(stream, objectToSerialize);
			}
			catch (SerializationException ex)
			{
				Console.WriteLine("Failed to serialize. Reason: " + ex.Message);
				throw;
			}
			finally
			{
				stream.Close();
			}
		}

		public static object DeserializeObjectFromFile(string path)
		{
			var formWindow = new object();

            FileStream fs = new FileStream(path, FileMode.Open);

            try
            {
                SoapFormatter formatter = new SoapFormatter();

                formWindow = formatter.Deserialize(fs);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }

            return formWindow;
		}

    }
}
