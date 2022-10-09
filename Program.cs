using System.ComponentModel;
using System.Data.Common;
using System.Dynamic;
using System.Globalization;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
public class Literals
{
    public void Example()
    {
        int firstInt = 10;
        uint uInt = 12U;
        long firstLlong = 12L;
        double firstDouble = 123D;
        ulong uLong = 123UL;
        float firstFloat = 879f;
        bool firstBool = true;
        decimal firstDeci = 1243M;
        char t = 'a';
        string h = "This sis ";
        short firstShort = 12;
        byte firstbyte = 122;
        ushort uShort = 122;
    }
}
public class ExampleOfEverloading
{

    public int x;
    public int y;
    public ExampleOfEverloading(int x, int y) { this.x = x; this.y = y; }
    public static ExampleOfEverloading operator +(ExampleOfEverloading a, ExampleOfEverloading b)
    {
        return new ExampleOfEverloading(a.x + b.x, a.y + b.y);
    }
    //we can do same for - % / * 'is' also method must be defined as static

    //Explicit and Implicit operator overloading - both defined below
    public static implicit operator ExampleOfEverloading(int a) { return new ExampleOfEverloading(a, a); }
    public static explicit operator int(ExampleOfEverloading a) { return a.x; }
    public delegate int Adding(int a, int b);

    public void otherOperators(ExampleOfEverloading a, ExampleOfEverloading b)
    {

        if (a.Equals(b)) { }
        if (a.GetHashCode == b.GetHashCode) { }
        ReferenceEquals(a, b);
        if (a.x > b.x || a.y == b.y || a.x != b.x || a.x < b.x || a.x <= b.x || a.x >= b.x) { }
        var t = a.x == 1 && a.y == 1 || a.x + a.y == 2;
        var ty = (a.x == 1) ? a.x + 1 : (a.y == 1) ? a.x + 2 : a.x + 3;
        var nullConditional = b?.y;
        var xor = false ^ true;
        int defaultEx = default(int);//whereas object string dynamic will be null 
        Console.WriteLine(sizeof(int));
        var nullCoalescing = a ?? b; // if a is null b will be returned
        int leftShift = 10 << 2;
        int ri8Shift = 10 >> 2;

        var lambdaExample = Enumerable.Range(1, 10).Max(x => x >> 2);

        Adding adding = (hj, jh) => { return hj + jh; };
        var deleExample = adding(12, 43);
        int? nullableInt = a?.x; //can be also used for indexing

        nullableInt++;
        ++nullableInt;

        Console.WriteLine(typeof(int) + " " + nameof(nullableInt));
        Console.WriteLine("AgregateObject".ToCharArray()[0]);



    }
}

public class ConditionalAndEqualityOperators
{
    public class IfExample
    {
        public static void ExampleForIf()
        {
            if (true || false) { }
            else if (true) { }
            else { }

        }
        public void EqualityOperatorExample()
        {
            Literals a, b;
            a = new Literals();
            b = new Literals();
            if (a == b) { }
            else if (ReferenceEquals(b, a)) { }
            else if (a.Equals(b)) { }
            else if ((Literals)a == (Literals)b) { }

        }

    }

}
public class StringOperationsAndFeatures
{

    public void VerbatimExample()
    {
        string s = @""" here{2-1} is the

        example/t/t/t/t/t/r/r/r/r/r";
        //lines will be preserved "" =one " /t/r will be as such  and 2-1=1

    }
    public void StringExample()
    {
        var a = String.Format("Im {0}", "Gowetham");
        a.ToCharArray().Reverse(); //reversing

        a.PadLeft(10);
        a.PadRight(6); //padding length must be greater than string.Length else no effect

        var test = string.IsNullOrEmpty(a) || string.IsNullOrWhiteSpace(a);
        // trimming
        a.Trim(); a.TrimEnd(); a.TrimStart();

        string number = "12";
        string.Format(number, 2); //second parameter is base
        string.Format(number, 8);
        string.Format(number, 16);

        //List/array or anyting to string
        var charlist = Enumerable.Range('A', 10);
        string t = string.Join("", charlist);
        //formating using toString
        string doubleValue = Double.MaxValue.ToString("0.0");
        string intValue = int.MaxValue.ToString("0000");

        //splitting a string
        var theString = "hello".Split("");
        var tSubString = t.Substring(0, 9);
        t.Replace('a', 'A');
        t.Remove('b');
        t.Contains(tSubString);
        t.StartsWith('A');
        t.EndsWith('b');
        t.ToUpper();
        t.ToUpperInvariant();
        t.ToLower();
        t.ToLowerInvariant();
        string.Concat(t, t);
        var concat = $"{t}{t}";

    }
    public void IntoStringFormat() {
        string first = String.Format("{0}{2}{1}", "1", "2", "3");
        DateTime dateTime = DateTime.Now;
        string dateTimeFormat1 = String.Format(dateTime.ToString(), "dd-MM-yyyy");
        string dateTimeFormat2 = String.Format(dateTime.ToString(), "d");
        string dateTimeFormat3 = String.Format(dateTime.ToString(), "D");
        string dateTimeFormat4 = String.Format(dateTime.ToString(), "f");
        string dateTimeFormat5 = String.Format(dateTime.ToString(), "F");
        string dateTimeFormat6 = String.Format(dateTime.ToString(), "dd-MM-yyyy-zzzz");
        string currency1 = String.Format("{0:C1}", 112);//1 is precison
        string currency2 = String.Format("{0:10:C1}", 112);//1 is precison 10 gives spaces to left -10 gives spaces to ri8

        //various way of concatenation
        string a = $"{"apple"}{"orange"}";
        StringBuilder stringBuilder = new StringBuilder();
        foreach (var aa in Enumerable.Repeat('A',20)) { stringBuilder.Append(aa); }
        a = a + a;
        string.Concat(a, a);
        a.IndexOf('a');a.LastIndexOf('a');

        //Interpolation
        var str = $"this is called string itnerpolation{a} {dateTime.ToString():dd-MM-yyyy}";
        //{value,padding}
        var space = $"{"10",10}";
        var deci = $"{a:D3}";
        var float1 = $"{a:F3}";
    
    }
    public void EscapeSequences() {
        var stringWithOut = "\" Im the chief of the Police\\ this is how single slash is printed \\";
        var stringWthVerbatim = @" ""Im the chief of the police \ this .. ";
    
    }
    public void stringBuilderExample() {
        StringBuilder stringBuilder = new StringBuilder(100);//we can specify the size
        stringBuilder.Append("Name"); //it will be more faster
        stringBuilder.EnsureCapacity(122);    
    }
    public void RegexExample() {
        Regex regex = new Regex(".*)");
        var t = regex.Matches("math this string");
        
    }
    public void DateTimeExample() {

        var dt1 = String.Format(DateTime.Now.ToString(), "{0:t}");
        var dt2 = String.Format(DateTime.Now.ToString(), "{0:d}");
        var dt3 = String.Format(DateTime.Now.ToString(), "{0:f}");
        var dt4 = String.Format(DateTime.Now.ToString(), "{0:T}");
        var dt5 = String.Format(DateTime.Now.ToString(), "{0:D}");
        var dt6 = String.Format(DateTime.Now.ToString(), "{0:F}");
        var dt7 = String.Format(DateTime.Now.ToString(), "{0:g}");
        var dt8 = String.Format(DateTime.Now.ToString(), "{0:r}");
        var dt9 = String.Format(DateTime.Now.ToString(), "{0:s}");

        var addDays = DateTime.Now.AddDays(12);
        var addDays2 = DateTime.Now.AddHours(12);

        DateTime Df1;
        var parsing = DateTime.TryParse("12/3/2022", out Df1);
        var parsing1 = DateTime.TryParseExact("12/3/2022","g",null,DateTimeStyles.None, out Df1);
        var parsing21 = DateTime.ParseExact("12/3/2022","g",null,DateTimeStyles.None);
        var parsing2 = DateTime.Parse("12/3/2022");

        Df1.ToShortDateString();
        Df1.ToLongDateString();
        var td1 = DateTime.Parse(dt1);
        var td2 = DateTime.Parse(dt1);
        DateTime.Compare(td1,td2);

    
    }
}
public class ArrayEx {
    public void Example() {
        int[] arr = new int[4] { 12,43,54,5};
        int[] ar = { 12, 43, 23, 43 };
        int[] arrr = new int[10];

        int[] arrReapeat = Enumerable.Repeat(12, 4).ToArray();
        var copyArray=new int[4];

        Array.Copy(arrReapeat, copyArray, 4);

        var arrt = arrReapeat.Clone();

        arrReapeat.CopyTo(copyArray,0);

        arrReapeat.SequenceEqual(copyArray);

        int[][] jaggedArray = new int[5][];
        for (int i= 0; i < 5; i++) {
            jaggedArray[i] = new int[12];
        }

    }

}
public class EnumExample
{
    public enum Bytes : byte
{
    Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
}
    //we ca also use it as flags
    [Flags]
    public enum Longs : long { 
    january=1>>2,febraury=10,March=24,April,Default=january
    }
    [Flags]
    public enum uInt : uint
    {
        [Description("Just for one time")]january = 1 >> 2,[Description("You are dead")] febraury = 10, March = 24, April, Default = january
    }
    Longs value = (Longs)20;
    Longs t;
    public void Example() {
        var t1 = Enum.GetNames(typeof(Longs));
        var t2 = Enum.GetName(typeof(Longs),10);

        uInt result;
        var t3 = Enum.TryParse("january",out result);
    
    }



}
public class Tuples {

    public void TuplesExample() {
        var tuple1 = new Tuple<string, int, int, string>("foo",12,43,"too");
        var tuple2 = ("foo",12,43,"too");
        var tuple3 = Tuple.Create("foo",12,43,"too");

        //we can have tuple in List too

        //Guid
        var t = Guid.Empty;
        t=Guid.NewGuid();

        //Biginterger
        BigInteger big = new BigInteger(1222222);
        big = big + 123;
        
    }

}
public class Collections {

    public void IntroExample() {
        List<int> list = new List<int>();
        Dictionary<int, int> dic = new Dictionary<int,int>();
        HashSet<string> b = new HashSet<string>();
        //queue stack soretedset more an dmore are there
        
    
    }
}
internal class Looping {

    public void Example() {
        for (int aaa = 0; aaa < 10; aaa += 2) {
            //
        }
        for (; true;) {
            //
        }
        while (true) { }
        do { } while (true);
        List<int> a = Enumerable.Range(0, 10).ToList();
        a.ForEach(x => { });
        foreach (var t in a) { }
        for (; ; ) { for (; ; ) { continue; } break; }

        List<int> aa = Enumerable.Range(1, 10).ToList();

        IEnumerable<int> Iter = aa.AsEnumerable();

        //it will hasve hasnext and crrent



    }
    public IEnumerable<int> YieldExample() {

        for (int i = 0; i < 10; i++) {
            yield return i;
        }
    }
    public void ValueTypeVsRefType() {
        // all the obj are ref and all variables are value
        int a = 10;

        //dffernce between out and ref is in ref value is preserved in out just variablee iss declared

    }
    public void ChangeValue(int a) { a = 10; }//will not chnage value
    public void ChangeValueRef(ref int a) { a = 111; }//will change value
    public void ChangeValueOut(out int a) { a = 14323; }//will change value

    public void BoxedValueExample() {
        //value iside object is called boxed value
        object i = (int)10;//boxed
        object j = (int)10;
        long t = (long)i;//will gives an error
        long tt = (long)(int)i;
        var comp = i == j;//false
        comp = i.Equals(j);//true

        //Alias names
        //like 
        System.Int32 a = 100;
        System.UInt16 a1 = 100;
        System.UInt32 a2 = 100;
        System.UInt64 a3 = 100;
        System.Int64 a4 = 100;
        System.Int16 a5 = 100;
        System.Char a6 = '1';
        System.String a7 = "100";
        System.Boolean a8 = true;
        //and there are many
    }

    public void AnonymousTypes() {
        var t = new { value = 10 };
        var y = new { foo = 10, Bar = 12 };
        var y2 = new { foo = 1, Bar = 122 };
        var y3 = new { foo = 110, Bar = 1122 };
        var y4= new { foo = 120, Bar = 1122 };
        var comp = y2.Equals(y);

        var list = new[] { y, y2 };
        var ty = new[] { new { value = 120 }, new { value = 091 } };

    
    }
    public void DynamicTypes() {
        dynamic info = new ExpandoObject();
        info.Id = 12;
        info.Gowtham = 12;
        dynamic foo = 123;

    
    }

    public void TypeConversion() {
        //explicit
        Double d = 100.999;
        int a = (int)d;
        if (a is int) { IEnumerable<int> aaa = Enumerable.Repeat(10, 2).AsEnumerable();
            aaa.OfType<int>();
            aaa.Cast<int>();
        }
        //implicit
        long aa = a;
        //nullable types
        int? nullableRi8 = null;
        var t=nullableRi8.HasValue;
       
        var tt = nullableRi8.GetValueOrDefault(0);
        //var rt = Nullable.GetUnderlyingType(typeof(nullableRi8));

    
    }
}