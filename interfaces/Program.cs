using _020820.Furnit;
using _020820.interfaces;
using _020820.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020820
{
    abstract class A
    {
        public abstract void Foo();

    }
    abstract class B : A
    {
        public override void Foo()
        {
            throw new NotImplementedException();
        }
    }
    abstract class D
    {
        public abstract void Print(string msg);
    }

    /// <summary>
    /// interface -> abstract class -> non-abstract class
    /// </summary>
    abstract class C : B, IPrinatble, IDancer // class can inherit ONLY from 1 base class!
    {
        public abstract string Dance(); // if you choose not to implement the abs methods
                                        // in your abstract class, you need to declare them only
        public virtual void Print(string msg)
        {

        }
        public override void Foo()
        {
            throw new NotImplementedException();
        }
    }
    class Son_C : C
    {
        public override string Dance()
        {
            throw new NotImplementedException();
        }

        public override void Print(string msg)
        {
            throw new NotImplementedException();
        }
    }

    interface IPrinatble
    {
        void Print(string msg); // public abstract 
    }
    interface IDancer
    {
        string Dance();
    }



    class Program
    {

        static void Draw3D(IDraw3D draw3D)
        {
            draw3D.DrawIn3D();
        }

        static void BankPaymentOfRent(IRentPayert payer)
        {
            payer.PayRent();
        }

        static void IriyaPayArnona(IArnonaPayer payer)
        {
            payer.PayArnona();
        }

        static void DrawCircle(Circle c)
        {

        }

        static void PaintIPaint(IPaintable paintable)
        {
            paintable.Paint();
        }

        static void PaintFurn(Furniture fur)
        {
            fur.Paint();
        }

        static void Main(string[] args)
        {
            // error -- IRunner i1 = new IRunner();

            IRunner i1 = new SportMan("dudi");
            

            Sofa s = new Sofa();
            PaintFurn(s);
            Fence f = new Fence();
            // error: PaintFurn(f);
            PaintIPaint(f);

            Circle c = new Circle();
            Draw3D(c);
            Person p = new Person();
            // Draw3D(p);

            SportMan sportMan = new SportMan("nahum");
            sportMan.Run();
            sportMan.GetName();
            sportMan.ToString();

            IRunner runner = sportMan;
            // object
            // Run (IRunner)
            runner.Run();

            object sp_obj = sportMan;
            object circle_obj = c;

        }
    }
}
