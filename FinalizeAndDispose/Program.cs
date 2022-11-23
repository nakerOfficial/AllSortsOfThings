using FinalizeAndDispose;

#region Working destructor
void Main()
{
    MyClass myClass = new MyClass();
    myClass.MyMethod();
}

Main();

GC.Collect();
GC.WaitForPendingFinalizers();
#endregion


#region Working despose
using (MyClass myClass2 = new MyClass())
{
    myClass2.MyMethod();
}
#endregion