using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    public interface ISerialize
    {
        int Length { get; }

        void fromFile(string path);
        void toFile(string path);
    }
}
