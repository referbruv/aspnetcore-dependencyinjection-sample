using System;

namespace DiReadersApp.Models
{
    public class Reader
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public DateTime AddedOn { get; set; }
    }
}