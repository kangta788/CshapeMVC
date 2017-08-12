using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    abstract class Shaps
    {
        public string ID;
        public abstract float Ares { get; }

        public virtual string ShowInfo()
        {

            return String.Format("ID:{0},Area:{1}", this.ID, this.Ares);
        }
    }


    class Rectangle : Shaps
    {

        public float Width, Height;
        public override float Ares
        {
            get
            {
                return this.Width * this.Height;
            }
        }

    }

    class Circle:Shaps
    {
        public float Radius;

        public override float Ares
        {
            get
            {
                return this.Radius*this.Radius*Convert.ToSingle(Math.PI);
            }
        }
    }
}
