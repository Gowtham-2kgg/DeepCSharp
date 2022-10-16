using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Dynamic;
using System.Globalization;
using System.Net.WebSockets;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

//
using random = System.Random;
using static System.Console;
using math =System.Math;
using st = System.Text;
using System.Data.SqlTypes;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Net;
using System.Net.Sockets;
#if True
#elif False
#else
#endif
#warning
internal class Program
{
    private static void Main(string[] args)
    {
//#error

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
public class Constructors {
    public string name { get; set; }
    static Constructors() { }//will be excecuted only once
    public Constructors():this("dog") { }//whenever obj is created this will be exe
    public Constructors(string name) { this.name = name; }
    ~Constructors() { }
}
public class Child<T> : Constructors { //generic
    public Child() : base() { }
    ~Child() { }
    
}

public static class StaticClass {
    //everything must be static under static classss
    public static int a;
    public static void method() { }

}
//acees modifiers public protected internal private and protected internal

//partical class can implement from only one base class implementing different will lead to error
public partial class Partiality:Constructors {
    public void Method1() { Console.Write("hai"); }
    public partial void Method2();
    public partial void Method3();

}
public partial class Partiality {

    public partial void Method2() {
        //
        Console.WriteLine("hello");
    
    }
    public partial void Method3()
    {
        //
        Console.WriteLine("hello");

    }
}
public class Methods {

    delegate int ExampleDele(int a);

    ExampleDele Ec = (z) => { return z * 2; };

    public static int ExampleForParams(params int[] a) { return 0; }
    int c=ExampleForParams(12,32,4324,34,3,2);
    //Extension methods are by this and static keyword
    public void NmaedArgumentsAndOptional(int left, int right, [Optional] int h,int y=100) {
        NmaedArgumentsAndOptional(right:20, left:12,h:10);
    //once if u use the variable name in paramenter u have to use for all 
    }

}
public class DataAnnotation {
    [Range(0,1000,ErrorMessage ="Reached max")]
    public int max;
    [StringLength(maximumLength:1000,MinimumLength =12,ErrorMessage ="Dont do this"),Editable(false)]
    public string name;
    [DataType(DataType.Date)]
    
    public DateTime date;
    [NotABrinjal("Brinjals not allowed")]
    public string veg { get; set; }
    public void Method() {
        ValidationContext validationContext = new ValidationContext("sir");//any reference can be added inside theis ()
        List<ValidationResult> validationResults = new List<ValidationResult>();
        bool isValid = Validator.TryValidateObject("hai", validationContext, validationResults,true);
    
    }

}
[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
public class NotABrinjal : ValidationAttribute {
    public NotABrinjal(string errorMessage) : base(errorMessage)
    {
    }

    public override bool IsValid(object? value)
    {
        string v = value as string;
        return !v.ToLower().Contains("brinjal");
    }
}
public class KeyWordparent {
    public virtual void Sign() { }
}
public class Keywords:KeyWordparent {
    public volatile int vol;
    public override void Sign()
    {
        
    }
    public static object u = new object();
    public void Example() {
       
        //as
        var t = (object)10 as int?;
        var y = "hai" as String;
    //Goto
    ExampleForGoto:

        goto ExampleForGoto;
        //volatile - to prevent modification during multi thread can be used only within struct or class
        ///uncheccked and checked
        int a = 100;
        while (a < 1000000000) {
            a=unchecked( a + a);//overflow will be ignored
        }
        while (a < 100000000000) {
            a = checked(a + a);//exception will be thrown of overlfow
        }

        //stackalloc allocate space in stack
        //byte* stack = stackalloc byte[1000]; -- used in unsafe

        while (true) {
            if (true) { break; }
            continue;
        }
        //const - value will be cosntant throghout the end starting from compile time(whereas readonly - runtime)
        const int yt = 12;
        //for
        for (; ; );
        //fixed -can be used inside struct

        //default
        int yr = default(int);
        var u = yr is int;
        Console.Write(typeof(int));
        Console.WriteLine(yr.GetType() == typeof(int));
        //foreach
        //this -used everywhere
        try { }
        catch { }
        finally { //price.Dispose();

            //void means nothing , namespace is file, ref out we know and....
            //lock (u) { }
            //
                }

    }
    public async Task ExampleForAsync() {
        await ExampleForAsync();
    }
    public extern void External();
    
}
public sealed class Se { }//cant inherit from it
public abstract class AbsExample{
    int ten;
    public abstract void Exam();
    public  void Exam1() { }

}
public class InheritAbs : AbsExample {
    readonly string _read;
    public void External() { }

    public InheritAbs() {
        _read = "kill";//only iside cons it can b einitialized
    }
public override void Exam() { } 
}
// T and V are used in Generics
public class Generics<T> where T:InheritAbs,new()
{
    public void Example<T1, T2>() { }
    public async Task<(V1, V2)> Exampleone<V1, V2>() {
        return ((V1)(object)1, (V2)(object)2);
    }
}
//CREATE A TYPE WITH EMPTY CONSTRUCTOR
public class foo
{ public foo(){ } }
public class bar {
    public bar(int a) { }
}
//have to call a new for using new
public class Createtype<T> where T:new(){

    public T create() { 
    return new T();
    }
}
public interface Interface1 { }
public interface Interface2 { }
public interface Interface3 { }
public class class1 { }

public class class2<T> where T:class1,Interface1,Interface2,new() {

        public void M() {
        var comparer = EqualityComparer<T>.Default;
    }
}
//reflection
public class ReflectionSample<T>{
    public string Example() {
        return typeof(T).Name;
    }
    delegate T Func<out T>();
    delegate void Action<in T>();
    delegate T Func2<in T1,out T>();
}
//Dispose is used to clear memory of unmanaged resource 
public class DisposeExmaple : IDisposable {
    private UnmanagedMemoryStream stream = null;
    public void Dispose() {
        stream.Dispose();
    }

}
//using will handle

public class ReflecctionExample {
    public int forGetterAndSetter { get; set; }

    public void Example() {

        var members = typeof(int).GetMembers(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance);
        //we can get all members using reflections
        foreach(var mem in members) {
            if (mem.DeclaringType.Equals(typeof(int).Name)) { }
        }
    }
    //getting a method using reflection
    public void MethodInvoke() {
        var method = "String".GetType().GetMethod("Substring", new[] { typeof(int), typeof(int) });
        var result = method.Invoke("string", new object[] { 1, 2 });
        //for static one
        var statmethod = typeof(Math).GetMethod("Exp");
        var result1 = statmethod.Invoke(null, new object[] { 1 });// for static function we can pass it as null

        //activator
        Type type = typeof(BigInteger);
        var r = Activator.CreateInstance(type);//without value
        var r1 = Activator.CreateInstance(type,123);///with value
        var t = Activator.CreateInstance(typeof(int), 123);

        Type geneType = typeof(List<>);
        Type[] arg = { typeof(string) };
        var y = geneType.MakeGenericType(arg);
        var resu = (List<string>)(Activator.CreateInstance(y));


        //creating strongly typed delegate
        var max = typeof(Math).GetMethod("Max", new[] { typeof(int), typeof(int) });
        var strongDelegate = (Func<int, int, int>)Delegate.CreateDelegate(typeof(Func<int, int, int>), null, max);
        //Getter
        var getter = typeof(ReflecctionExample).GetProperty("forGetterAndSetter");
        var getterIn = getter.GetGetMethod();
        var getterDele = (Func<ReflecctionExample, int>)Delegate.CreateDelegate(typeof(Func<ReflecctionExample, int>), getterIn);

        //same can be used for settion -we can use action or function
        var gene = typeof(ReflecctionExample).GetMethod("GetInstance");
        MethodInfo generic = gene.MakeGenericMethod(typeof(string));
        generic.Invoke(null, null);

        //PropertyInfo prop = ReflecctionExample.GetType().GetProperty("");
        //// get the value myInstance.myProperty
        //object value = prop.GetValue(myInstance);
        //int newValue = 1;
        //// set the value myInstance.myProperty to 
        var linqWithparallel = Enumerable.Range(1, 100).AsParallel().WithDegreeOfParallelism(10).OrderBy(c => c);

    }
    public T GetInstance<T>()where T : new()
        {
        return new T();
    }
}
public class XmlDemo {
    public void Example() {

        var file = "xmlFile";
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.Load(file);
        //creating xml
        XDocument xDocument = new XDocument(
        new XElement("Root",new XAttribute("name","value"),new XElement("child","node")));

        XmlNode xmlNode = xmlDocument.SelectSingleNode("node");
        xmlNode.InnerText ="10";
        XElement xElement = xDocument.XPathSelectElement("name");

        xmlDocument.Save(file);
        
    }
}
public class CSharpSevenFeatures {

    //Tuples
    public (int a, int b) ReturnTuple() { return (1, 2); }
    public void UseTuple() 
    {
        var tup = ReturnTuple();
        int a = tup.a;
        int b = tup.b;
        var t = new TUpleDeconstruct { Fn = 10,Ln=12 };
        var ex = new TupExample((1,2));
        var (ex1, ex2) = (ex.name.first,ex.name.second);

        var anoTuple = (12, 34);
        var anoTuple1 = (first:12, second:34);
        var y = anoTuple.Item1;
        var ts = anoTuple1.first;


         int getThisInt(){ return 1; } //can't be accessed anywhere except this method

        //int (Fn, Ln) = t; Deconstruct

        var tryParsing = int.TryParse("10", out var yr);//we can declare var in parameter of try parse

        //by pattern matching in swich case we can use class

        string aaa = "10" as string;
        string aa1 = "10" is string?("10"):"1";

        int digitSep = 12_23_23;//new feature
        //binary literals in enum and we can use throw during terenery operator -new features
    }
    public ref int ReturnRef(ref int g) {
        return ref g;
    }
    public ValueTask<int> ReturnValueTask() {
        return new ValueTask<int>(12);

    }
    public (int sum, double average) Measure(List<int> items)
    {
        var stats = (sum: 0, average: 0d);
        stats.sum = items.Sum();
        stats.average = items.Average();
        return stats;
        
    }
    public class TUpleDeconstruct {
       
    public int Fn { get; set; }
    public int Ln { get; set; }
        public void Deconstuct(ref int fn, ref int ln) {
            this.Fn = fn;
           this. Ln = ln;
            try
            {
                throw new GowthamException();
            }
            finally { GC.Collect(); }
        }
    }
    public class TupExample {
        public (int first, int second) name { get; }
        public TupExample((int first, int second) name){
            this.name = name;
}
    }
}
//C# 3.0 have var, linq,anonymous types lambda expression C#4 got optional and reference and dynamic as newly included features c#5 got async and awit c#5 includes string interpolation ? and many such
//Excceptions

[Serializable]//serializable
public class GowthamException : Exception {
    public GowthamException():base("Im excepting an exception") { }
    public GowthamException(string fileName,int lineNumber):base($"Exception happens because of this {fileName} and in this file at line{lineNumber}") { }
    string fileName { get; set; }
    string lineNumber { get; set; }
    //rethorwing
    public GowthamException(string fileName, Exception innerExe) : base(fileName, innerExe) { }
}
//when u trow ception at catch its called exception anti-patterns
//Aggregate exception we can throw multiple exception
public class ExampeForMultipleExe {
    public void Example()
    {
        try
        {
            this.GetExe(1, 2);
        }
        catch (AggregateException e) { 
        
        }
    }
    public void GetExe(int a, int b) {

        var exceptions = new List<Exception>();
        exceptions.Add(new NullReferenceException("this is null"));
        exceptions.Add(new ArgumentException("arguments is null"));
        //UnhandledExceptionEventHandler(exceptions);
        throw new AggregateException(exceptions);
        try
        {
            try { }
            catch { }
        }
        catch { }
    }
    //nullrefexe and formatexe

}
public class ExampleOOfListerners {
    public void ExampleForListerners(){
        TextWriterTraceListener textWriterTrace = new TextWriterTraceListener("Filename.txt");
        //Debug.Listerners.add(textWriterTrace);Debug.WriteLine("hello");textWriterTrace.Flush();
        ConsoleTraceListener consoleTrace = new ConsoleTraceListener();
        //Debug.Listernes.add(consoleTrace);
        int a = int.MaxValue;
        int b = unchecked(a + 1);//called overflow
        long h = a + 1;//overflow it must be unchecked(a+1)
        long jh = a + 1L;//not overflow
        Console.WriteLine(a + a + 1L);//-1
        Console.WriteLine(a + 1L+a);//value
}
}
//we know well about JSON
//lambda expression can be used in event handling also
[Obsolete]
public class Lambda:INotifyPropertyChanged {


    //getters and setters
    int po { get { return this.po; } }
    int h { set { this.h = value; } }
    int first { get; set; } = 100;
    delegate int add(int a, int b);
    delegate string voider();
    Func<int,int> func = (a) => { return a+1; };

    Action act = () => { Console.Write("hai"); };

    public event PropertyChangedEventHandler? PropertyChanged;

    public void ExampleOfEventHandler() {
        EventHandler handler = (sender, args) => Console.WriteLine("Email");
        add kc=(a, b) => (a+b);
        kc(1, 2);
        voider c = () => "hi";
        c();
        

    }
}
//params can be also used in oerloading 
//Binding list is also a DT
[System.AttributeUsage(System.AttributeTargets.Method|System.AttributeTargets.Class)]

public class StrucExam:Attribute {
    public struct Triangle {
        private int length;
        internal int height;
        //protected int breadth;
        public int breadth;
        public Triangle(int length, int height, int breadth) {
            this.length = length;
            this.height = height;
            this.breadth = breadth;
        }
        public int Area()  { return this.length * this.breadth * this.height; }
    }
    Triangle a = new Triangle(1, 1, 1);
    int area = a.Area();
    //exception and attributes
    public void Exception(Exception ex, [CallerMemberName] string callerMemberName = "", [CallerFilePath] string path = "", [CallerLineNumber] int linenp = 1) {
    //Do logging
    }
    public void FunctionForFun() {
        try { throw new Exception(); }
        catch (Exception a)
        {
            Exception(a);
        } }
}
[DebuggerDisplay("{Id}{Number}")]
public class AttributeExample : Attribute {
    public int Id { get; set; }
    public int Number { get; set; }
    public int Numeral { get; set; }
    public void Example() {
        var atributes = typeof(StrucExam).GetCustomAttributes();
    }
}
//creating custom attribute
public class NoMethodAttribute : System.Attribute {
    public NoMethodAttribute() { }
}
public class DelegatesExample {
    public delegate int Square(int a);
    public delegate Tflag Converter<in Tto, out Tflag>(Tto input) where Tto : new() where Tflag : new();
    public delegate bool Boller(int input);
    Predicate<int> pred = s => s.ToString().StartsWith("a");
    Func<int,bool> preda = s => s.ToString().StartsWith("a");
    //Action and delegate both are same
    public void Exaxmple(){
    Square c=(x) => x* x;
}
}
public class FileIo {
    public void Example() {
        string file = System.IO.File.ReadAllText("file");
        string[] file1 = System.IO.File.ReadAllLines("file");
        IEnumerable<string> file2 = System.IO.File.ReadLines("file",Encoding.Default);
        System.IO.File.WriteAllLinesAsync("file",file2);
        File.Copy("file", "jail");
        File.Move("file", "NewPlancce");
        File.Delete("file");
        var files = Directory.GetFiles("file", ".", SearchOption.AllDirectories);
    }
}
public class Networking {

    public class Tcp {

        public void ExmapleDownloadFile() {
            using (var webClient = new WebClient()) {
                webClient.DownloadFile("url", "download path");
                //webClient.DownloadFileAsync($, "download path");
                //webClient.DownloadDataCompleted += new AsyncCompletedEventHandler(completed);
                //webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            }
        }
    }
    public class udp {
        public int Port = 111;
        public string IpAddr = "192.168.1.141";
        byte[] data = Encoding.ASCII.GetBytes("hai");
        public void ExampleOfUdp()
        {
            try {
                using (var client = new UdpClient()) {
                    IPEndPoint ip = new IPEndPoint(IPAddress.Parse(IpAddr), Port);
                    client.Connect(ip);
                    client.Send(data, data.Length);
                }
            }
            catch { }

            using (var udpListerner = new UdpClient(Port)) { 
            
            }
        }

    }
}
public class HttpExample {
    public void Example() {
        HttpWebRequest httpWebRequest =  HttpWebRequest.CreateHttp("googje");
        httpWebRequest.Method = "POST";
        httpWebRequest.ContentType = "*/*";
        httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip;
        using (var resp = httpWebRequest.GetResponse()) { 
        }
    
    }
}
