namespace CloneObject
{
    internal class Person : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }

        public object Clone()
        {
            var person = (Person)MemberwiseClone();
            person.Address = (Address)Address.Clone();
            return person;
        }
    }
}
