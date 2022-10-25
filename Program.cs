using SerializacaoEDeserializacao.Models;
using Newtonsoft.Json;

//Enviar os dados para um cliente via JSON.
//Passo 1 - Criar o obj
//Paso 2 - Serializar o obj
//Passo 3 - Arquivo pronto para envio.

//Lista de objetos
List<Sale> sales = new List<Sale>();

//Objeto
Sale sale1 = new Sale(1, "Camisa", 24.50M, DateTime.Now);
Sale sale2 = new Sale(2, "Bermuda", 74.50M, DateTime.Now);

sales.Add(sale1);
sales.Add(sale2);

//Lista de objetos serializado no formato texto em Json.
string serializer = JsonConvert.SerializeObject(sales, Formatting.Indented);

//Arquivo pronto para ser enviado para o cliente
//com o conteúdo do objeto acima serializado.
File.WriteAllText("Files/saleJson.json", serializer);

Console.WriteLine(serializer);

//Deserializando
//Importar um arquivo json em nosso sistema e transformá-lo em um objeto.

string file = File.ReadAllText("Files/pessoaJson.json");

List<Person> people = JsonConvert.DeserializeObject<List<Person>>(file);

foreach(var p in people)
{
    Console.WriteLine($"Id: {p.Id} | Idade: {p.Age} | Nome: {p.Name} | Entrada: {p.EntryDate.ToString("dd/MM/yyyy")}");
}