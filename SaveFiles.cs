using System;
using System.Collections.Generic;
using System.IO;

namespace Inchirieri_de_casete_video
{
    public class DataHandler
    {
        private string clientsFilePath;
        private string moviesFilePath;
        private string rentalsFilePath;
        public DataHandler(string clientsFilePath, string moviesFilePath, string rentalsFilePath)
        {
            this.clientsFilePath = clientsFilePath;
            this.moviesFilePath = moviesFilePath;
            this.rentalsFilePath = rentalsFilePath;
        }
        public void SaveClients(List<Client> clients)
        {
            SaveData(clients, clientsFilePath);
        }

        public void SaveMovies(List<Movie> movies)
        {
            SaveData(movies, moviesFilePath);
        }

        private void SaveData<T>(List<T> data, string filePath)
        {
            try
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                using (StreamWriter writer = new StreamWriter(fileStream))
                {
                    foreach (var item in data)
                    {
                        writer.WriteLine(item.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving data: {ex.Message}");
            }
        }
        public List<Client> RestoreClients()
        {
            return RestoreData<Client>(clientsFilePath);
        }

        public List<Movie> RestoreMovies()
        {
            return RestoreData<Movie>(moviesFilePath);
        }

        private List<T> RestoreData<T>(string filePath)
        {
            List<T> data = new List<T>();

            try
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Assuming that each line represents one serialized object
                        T item = Deserialize<T>(line);
                        if (item != null)
                        {
                            data.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error restoring data from {filePath}: {ex.Message}");
            }

            return data;
        }

        private T Deserialize<T>(string fileData)
        {
            try
            {
                // Convert the serialized data back to object
                return (T)Convert.ChangeType(fileData, typeof(T));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deserializing data: {ex.Message}");
                return default(T);
            }

        }
    }
}
