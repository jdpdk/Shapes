using Shapes.Services;
using Shapes.Services.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Test.ClassData
{
    public class AreaServiceTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new List<IArea>()
                {
                    new Square()
                    {
                        Height = 10,
                        Width = 10,
                    },
                }, 
            100};

            yield return new object[]
            {
                new List<IArea>()
                {
                    new Square()
                    {
                        Height = 10,
                        Width = 10,
                    },
                    new Circle()
                    {
                        Radius = 10,
                    },
                    new Triangle()
                    {
                        A = 2,
                        B = 2,
                        C = 2
                    },
                },
            415.8913161665482};

        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
