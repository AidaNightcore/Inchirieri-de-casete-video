﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Inchirieri_de_casete_video
{
    public class DataHandler
    {
        private string clientsFilePath;
        private string moviesFilePath;
        private string rentalsFilePath;

        public DataHandler(string v_clientsFilePath, string v_moviesFilePath, string v_rentalsFilePath)
        {
            clientsFilePath = v_clientsFilePath;
            moviesFilePath = v_moviesFilePath;
            rentalsFilePath = v_rentalsFilePath;
        }

        public void SaveClients(List<Client> clients)
        {
            SaveData(clients, clientsFilePath);
        }

        public void SaveMovies(List<Movie> movies)
        {
            SaveData(movies, moviesFilePath);
        }
        public void SaveRentals(List<Rental> rentals)
        {
            SaveData(rentals, rentalsFilePath);
        }

        private void SaveData<T>(List<T> data, string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    using (FileStream createStream = File.Create(filePath))
                    {
                        using (StreamWriter writer = new StreamWriter(filePath, true))
                        {
                            foreach (var item in data)
                            {
                                writer.WriteLine(item.ToString());
                            }
                        }
                    }
                }
                else
                    using (StreamWriter writer = new StreamWriter(filePath, true))
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
