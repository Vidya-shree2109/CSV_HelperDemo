using CSV_HelperDemo;
using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace CSVExampleProblem
{
    public class PersonDataManagements
    {
        string IMPORT_FILEPATH = @"E:\PracticeProblems\CSVHelperDemo\CSV_HelperDemo\CSV_HelperDemo\Address.csv";
        string EXPORT_FILEPATH = @"E:\PracticeProblems\CSVHelperDemo\CSV_HelperDemo\CSV_HelperDemo\Export.csv";
        const string EXPORT_JSON_FILENAME = @"E:\PracticeProblems\CSVHelperDemo\CSV_HelperDemo\CSV_HelperDemo\Export.json";
        public void ImplementationCsv()
        {
            using (var reader = new StreamReader(IMPORT_FILEPATH))
            {
                using (var Csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = Csv.GetRecords<Address>().ToList();
                    foreach (var data in records)
                    {
                        Console.WriteLine(data.FirstName + " " + data.LastName + " " + data.Email + " " + data.Phone + " " + data.City + " " + data.State + " " + data.Country);
                    }
                    using (var writer = new StreamWriter(EXPORT_FILEPATH))
                    {
                        using (var CsvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                        {
                            CsvExport.WriteRecords(records);

                        }
                    }
                }
            }
        }
        public void ImplementationJson()
        {
            using (var reader = new StreamReader(IMPORT_FILEPATH))
            {
                using (var Csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = Csv.GetRecords<Address>().ToList();
                    foreach (var data in records)
                    {
                        Console.WriteLine(data.FirstName + " " + data.LastName + " " + data.Email + " " + data.Phone + " " + data.City + " " + data.State + " " + data.Country);
                    }
                    JsonSerializer serializer = new JsonSerializer();
                    using (var writer = new StreamWriter(EXPORT_JSON_FILENAME))
                    {
                        using (var jsonWriter = new JsonTextWriter(writer))
                        {
                            serializer.Serialize(writer, records);
                            
                        }
                    }
                }
            }
        }
    }
}