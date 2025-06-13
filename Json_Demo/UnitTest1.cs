using Newtonsoft.Json;

namespace Json_Demo;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        //json
        var json =
            "{\"Id\":1,\"Name\":\"John Doe\",\"Age\":30,\"IsActive\":true,\"Address\":{\"Street\":\"123 Main St\",\"City\":\"Anytown\",\"State\":\"CA\",\"ZipCode\":\"12345\"},\"Tags\":[\"tag1\",\"tag2\",\"tag3\"]}";

        // Deserialize JSON to object
        var person = JsonConvert.DeserializeObject<Person>(json);
       
    }
}

public class Address
{
    public string Street { get; set; }

    public string City { get; set; }

    public string State { get; set; }

    public string ZipCode { get; set; }
}

public class Person
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int Age { get; set; }

    public bool IsActive { get; set; }

    public Address Address { get; set; }

    public IList<string> Tags { get; set; }
}
