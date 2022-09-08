using System.Globalization;
//Console.WriteLine("Hej, Vad heter du?");
//string name = Console.ReadLine();
//Console.WriteLine($"Hej {name}");
//-------------------------------------------------------


string svar = "";

Console.WriteLine("Det är en grå dag i Farsta, solen gömd bakom molnen och gatulamporna snodda");
Console.WriteLine("Du har precis handlat och är på väg hem när du ser en pundare i trappan du behöver gå ner");
Console.WriteLine("Går du ner?");

svar = Console.ReadLine();
svar = svar.ToLower();

if (svar == "nej")
{
    Console.WriteLine("Du tar den långa Farsta vägen hem");
    Console.WriteLine("Du kommer hem men du var borta för länge, någon har stulit allt du har");
   Console.WriteLine("");
    Console.WriteLine("THEFT ENDING");
}
else if (svar =="ja") 
{
     Console.WriteLine("Du kommer fram till pundaren och han säger Hej Hej och skakar på sin kopp");
     Console.WriteLine("Ger du han din växel från när du köpte maten?");

    svar = Console.ReadLine();
    svar = svar.ToLower();

    if (svar =="ja")
    {
        Console.WriteLine("Manen tackade dig och du gick in i ditt hus");
        Console.WriteLine("Du kom hem och märkte nån har snott din säng åtminstonde men du är hemma");
        Console.WriteLine("GOOD ENDING");
    }
    else if (svar =="nej")
    {
        Console.WriteLine("Du låtsas inte se honom och går förbi");
        Console.WriteLine("När du vänder ryggen så attackerar manen i ilska");
        Console.WriteLine("Du knockas ner till marken och farsta gaffeln åker in i magen");
        Console.WriteLine("BAD ENDING");
    }
}

Console.ReadLine();


