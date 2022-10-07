using System.ComponentModel;
using System.Data.Common;
using System.Reflection.Metadata.Ecma335;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
public class Literals {
    public void Example() {
        int firstInt = 10;
        uint uInt = 12U;
        long firstLlong = 12L;
        double firstDouble = 123D;
        ulong uLong = 123UL;
        float firstFloat = 879f;
        bool firstBool= true;
        decimal firstDeci = 1243M;
        char t = 'a';
        string h = "This sis ";
        short firstShort = 12;
        byte firstbyte = 122;
        ushort uShort = 122;
    }
}
public class ExampleOfEverloading {

    public int x;
    public int y;
    public ExampleOfEverloading(int x, int y) { this.x = x;this.y = y; }
    public static ExampleOfEverloading operator +(ExampleOfEverloading a, ExampleOfEverloading b) {
        return new ExampleOfEverloading(a.x + b.x, a.y + b.y);
    }
    //we can do same for - % / * 'is' also method must be defined as static

    //Explicit and Implicit operator overloading - both defined below
    public static implicit operator ExampleOfEverloading(int a) { return new ExampleOfEverloading(a, a); }
    public static explicit operator int(ExampleOfEverloading a) { return a.x; }


    public void otherOperators(ExampleOfEverloading a, ExampleOfEverloading b) {

        if (a.Equals(b)) { }
        if (a.GetHashCode == b.GetHashCode) { }
        ReferenceEquals(a, b);
        if (a.x > b.x || a.y == b.y || a.x != b.x || a.x < b.x || a.x <= b.x || a.x >= b.x) { }
        var t = a.x==1 && a.y==1 || a.x+a.y==2;
        var ty=(a.x == 1) ? a.x+1 : (a.y == 1) ? a.x+2 : a.x+3;
        var nullConditional = b?.y;
        var xor = false ^ true;
        int defaultEx = default(int);//whereas object string dynamic will be null 
        Console.WriteLine(sizeof(int));
        var nullCoalescing = a ?? b; // if a is null b will be returned
        int leftShift = 10 << 2;
        int ri8Shift = 10 >> 2;

        var lambdaExample = Enumerable.Range(1, 10).Max(x => x >> 2); 





    }
}

}