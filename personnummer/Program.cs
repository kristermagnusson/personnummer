bool t;
string personnummer;
Console.WriteLine("ange personnummer");
personnummer = Console.ReadLine();
t=TestPersNr(personnummer);
Console.WriteLine(t);




bool TestPersNr(string personnummer)
{
    string Pnr = personnummer.Replace("-", "");
    if (Pnr.Length == 12)
        Pnr = Pnr.Remove(0, 2);
    //int a;
    //if (int.TryParse(Pnr, out a) == false)
    //{
    //    Console.WriteLine("no parse");
    //    return false; 
    
    //}
    int Total = 0;
    int Temp = 0;
    for (int i = 0; i < Pnr.Length - 1; i++)
    {
        Temp = int.Parse(Pnr[i].ToString());
        if (i % 2 == 1)
        {
            Total = Total + Temp;            
        }
        if (i % 2 == 0)
        {
            Temp = 2 * Temp;
            if (Temp > 9)
            {

                Temp = Temp % 10 + Temp / 10;
            }
            Total = Total + Temp;           
        }        
    }
Console.WriteLine(Total);
    Console.WriteLine(Pnr);
    if (   (Total % 10 + int.Parse(Pnr[9].ToString()) ) % 10 == 0     )
        return true;
    else return false;

}




