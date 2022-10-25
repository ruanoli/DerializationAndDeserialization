using Newtonsoft.Json;

namespace SerializacaoEDeserializacao.Models
{
    public class Person
    {
        public int Id { get; set; }

        [JsonProperty("Name_Person")] //Atributo
        public string? Name { get; set; }
        public int Age { get; set; }
        public DateTime EntryDate { get; set; }
    }
}