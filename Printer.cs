using System;

namespace knightmoves;

public class Printer {
    public string Print(string dateString) {
        DateTime parsedDate = DateTime.Parse(dateString);
        
        return parsedDate.Year.ToString();
    }
}

