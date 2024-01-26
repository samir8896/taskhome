using System;

Console.WriteLine("Adinizi daxil edin");
string ad = Console.ReadLine();

Console.WriteLine("soyadinizi daxil edin");
string soyad = Console.ReadLine();

Console.WriteLine("Ata adini daxil edin");
string ataadini = Console.ReadLine();

Console.WriteLine("Cinsiyyeti daxil edin");
string cinsiyyet = Console.ReadLine();

Console.WriteLine("Dogum tarixini daxil edin");
int dogumtarixi = int.Parse(Console.ReadLine());

Console.WriteLine("Unvaninizi daxil edin");
string unvan = Console.ReadLine();

if (cinsiyyet == "kisi")
{
    cinsiyyet = "oglu";

}
else if(cinsiyyet == "qadin")
{
    cinsiyyet = "qizi";
}
int yas = 2024 - dogumtarixi;
string yasdovru;
string netice;
if (0 < yas && yas <= 11)
{
    yasdovru = "usaqliq";
}

else if (11 < yas && yas <= 16)
{
    yasdovru = "yeniyetmelik";
}

else if (16 < yas && yas <= 18)
{
    yasdovru = "erken genclik";

}
else if (18 < yas && yas <= 21)
{
    yasdovru = "genclik";
    netice = "qeyde alinmisdir";
}



else if (21 < yas && yas <= 65)
{
    yasdovru = "orta yas";
}

else
{
    yasdovru = "qocaliq";
}

if(yas>18 && yas <= 21)
{
    netice = "qeyde alinmisdir";
}

else
{
    netice = "qeyde alinmamisdir";
}
Console.WriteLine("siz " + ad + " " + soyad + " " + ataadini + " " + cinsiyyet+","+dogumtarixi+" doguldugunuz ucun hal-hazirda "+yas+" yasiniz vardir.Azerbaycan qanun vericiliyine uygun olaraq "+yasdovru+" dovrunuzu yasamaqdasiniz.bu is yerine sadece genclik doneminde olan sexsler muraciet ede bilerler.bu telebi nezere alaraq sizin muracietiniz "+netice);

