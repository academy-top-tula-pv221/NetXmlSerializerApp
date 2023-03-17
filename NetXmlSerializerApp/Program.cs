using ExampleClassLibrary;
using System.Xml;
using System.Xml.Serialization;

List<User> users = new List<User>()
{
    new User("Joe", 34, new Address(){ City = "Moscow", Street = "Tverskaya"}),
    new User("Tom", 41, new Address(){ City = "Orel", Street = "Lenina"}),
};

XmlSerializer serializer = new XmlSerializer(typeof(List<User>));

//using (FileStream stream = new FileStream(@"D:\myusers2.xml", FileMode.Create))
//{
//    serializer.Serialize(stream, users);
//}

using (FileStream stream = new FileStream(@"D:\myusers2.xml", FileMode.Open))
{
    List<User> users2 = (List<User>)serializer.Deserialize(stream)!;
    foreach(User user in users)
        Console.WriteLine(user);
}