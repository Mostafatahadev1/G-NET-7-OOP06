namespace G_NET_7_OOP06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1 Q1
            // Abstraction in OOP means hiding complex implementation details
            // and showing only the essential features of an object to the user.

            // Encapsulation means wrapping data and methods inside a class
            // and restricting direct access to the data using access modifiers
            // like private and public.

            // Difference:
            // Abstraction focuses on hiding complexity and showing what an object does.
            // Encapsulation focuses on protecting data and controlling access to it.

            // Real-world example:
            // A car driver uses the steering wheel, brake, and accelerator
            // without knowing how the engine works (Abstraction).
            // The engine components are hidden and protected inside the engine system
            // and cannot be accessed directly (Encapsulation).

            #endregion

            #region Part 1 Q2
            // Difference between Abstract Class and Interface:

            // 1) Abstract class can have implemented methods, but interface usually has only method signatures.
            // 2) Abstract class can have fields and constructors, interface cannot.
            // 3) A class can inherit from one abstract class only, but it can implement multiple interfaces.
            // 4) Abstract class members can use different access modifiers, interface members are public by default.

            // When to use:
            // Use an abstract class when classes share common code.
            // Use an interface when different classes need the same contract but different implementations.

            #endregion


        }
    }
}
