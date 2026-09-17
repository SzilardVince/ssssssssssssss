string nev = "Márton Károly";
int megtettav = 14;
bool eszakai = true;
double alapdij = 1100;
double kmdij = 440;
double osz2=0;
double eszakai_potlek = 1.20;
double osz1 = alapdij+(kmdij*megtettav);
if (eszakai)
{
    osz2 = osz1 * eszakai_potlek;
}
else
{
    osz2 = osz1;
}
Console.WriteLine($"utas neve: {nev}");
Console.WriteLine($"megtett távolsag: {megtettav} km");
Console.WriteLine($"alapertek: {osz1} Ft");
Console.WriteLine($"fizetendo osszeg: {osz2} Ft");
Console.WriteLine($"státusz: {(eszakai_potlek-1)*100} %");