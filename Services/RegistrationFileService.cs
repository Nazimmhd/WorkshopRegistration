
using System.Text.Json;
using WorkshopRegistration.Models;

namespace WorkshopRegistration.Services
{
    public class RegistrationFileService
    {
        private readonly string _filePath;

        public RegistrationFileService(IWebHostEnvironment environment)
        {
            string dataFolder = Path.Combine(
                environment.ContentRootPath, "Data");

            Directory.CreateDirectory(dataFolder);

            _filePath = Path.Combine(
                dataFolder, "registrations.json");
        }

        public void SaveRegistration(Registration registration)
        {
            string json = JsonSerializer.Serialize(registration);

            File.AppendAllText(
                _filePath,
                json + Environment.NewLine);
        }

        public List<Registration> GetRegistrations()
        {
            var registrations = new List<Registration>();

            if (!File.Exists(_filePath))
            {
                return registrations;
            }

            foreach (string line in File.ReadAllLines(_filePath))
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                var registration =
                    JsonSerializer.Deserialize<Registration>(line);

                if (registration != null)
                {
                    registrations.Add(registration);
                }
            }

            return registrations;
        }
    }
}
