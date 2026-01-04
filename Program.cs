using System.Text.Json;
using System.Text.Json.Serialization;

var employee = new Employee
{
    Id = 1,
    EmpName = "Vinayak",
    DepartMentName = "Develpment",
    Designation = ".NET Developer",
    Salary = 5000
};

string jsonserialize = JsonSerializer.Serialize(employee, new JsonSerializerOptions
{
    WriteIndented = true
}
);

string fileName = "WeatherForecast.json";
File.WriteAllText(fileName, jsonserialize);
Console.WriteLine(File.ReadAllText(fileName));

string jsonDeserialize = File.ReadAllText(fileName);
Employee? emp = JsonSerializer.Deserialize<Employee>(jsonDeserialize);
if (emp != null)
{
    Console.WriteLine("\n" + emp.Id);
    Console.WriteLine(emp.EmpName);
    Console.WriteLine(emp.DepartMentName);
    Console.WriteLine(emp.Designation);

}
else
{
    Console.WriteLine("Deserializtion Failed");
}

class Employee
{
    public int Id { get; set; }
    public required string EmpName { get; set; }
    public required string DepartMentName { get; set; }
    public required string Designation { get; set; }
    [JsonIgnore]
    public int Salary { get; set; }
}
