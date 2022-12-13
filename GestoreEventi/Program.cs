// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


DateTime dataOraAttuale = DateTime.Now;

Console.WriteLine("Inserisci una data: ");
string dataStringa = Console.ReadLine();

DateTime dataInserita = DateTime.Parse(dataStringa);

TimeSpan intervalloDiTempo = dataInserita - dataOraAttuale;

if (dataInserita >= dataOraAttuale)
{
    Console.WriteLine("La data inserita è futura!");
    Console.WriteLine("In particolare la tua data sta " + intervalloDiTempo.Days + " giorni nel futuro!");
}
else
{
    Console.WriteLine("La data inserita è passata!");
    Console.WriteLine("In particolare la tua data sta " + intervalloDiTempo.Days + " giorni nel futuro!");
}









