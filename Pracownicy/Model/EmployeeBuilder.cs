using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Pracownicy.Model
{

    class EmployeeBuilder
    {
        private static List<Employee> _list = new List<Employee>();
        public List<Employee> EmployeeList => _list;

        public void AddEmployee(Employee e) => _list.Add(e);

        public void Saving()
        {
            Stream stream = File.OpenWrite("employees.xml");
            XmlSerializer xmlserializer = new XmlSerializer(typeof(List<Employee>));
            xmlserializer.Serialize(stream, _list);
            stream.Close();
        }

        public void Loading()
        {
            List<Employee> employeelist = new List<Employee>();
            XmlSerializer xmlserializer = new XmlSerializer(typeof(List<Employee>));
            try
            {
                using (FileStream stream = File.Open("employees.xml", FileMode.Open))
                {
                    employeelist = (List<Employee>)xmlserializer.Deserialize(stream);
                }
                _list = employeelist;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File does not exist");
            }
        }
    }
}
