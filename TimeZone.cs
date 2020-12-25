using System;
using System.Globalization;

class TimeZoneDemo
{
    static void Main( )
    {
        Console.WriteLine("_________________");

        /////////////////////////
        const string dataFmt = "{0,-30}{1}";
        const string timeFmt = "{0,-30}{1:yyyy-MM-dd HH:mm}";

        /////////////////////////

        // Hakee ajan ja nyky hetkisen pv.kk.yyyy
        TimeZone localZone = TimeZone.CurrentTimeZone;
        DateTime currentDate = DateTime.Now;
        int      currentYear = currentDate.Year;

        // Etsii koordinoitu yleisajan eli UTC
        // aika vyöhyke.
        Console.WriteLine( dataFmt, "Standard time name:", 
            localZone.StandardName );
        Console.WriteLine( dataFmt, "Daylight saving time name:", 
            localZone.DaylightName );

        Console.WriteLine("_________________");

        // Tulostaa nyky ajan ja hetkisen aika
        // sekä onko kesä-vai talviaika, vain totta vai taru
        Console.WriteLine( "\n" + timeFmt, "Current date and time:",
            currentDate );
        Console.WriteLine( dataFmt, "Daylight saving time?", 
            localZone.IsDaylightSavingTime( currentDate ) );

        ///
        DateTime currentUTC = 
            localZone.ToUniversalTime( currentDate );
        TimeSpan currentOffset = 
            localZone.GetUtcOffset( currentDate );


        //Uusi tulostus, että tänään on pälä pälä....
        DaylightTime daylight = 
            localZone.GetDaylightChanges( currentYear );

        Console.WriteLine("\n Tänään on: " + currentYear + "\t" + currentUTC + "\n");
    } 
} 
