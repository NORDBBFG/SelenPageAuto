using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelenPageAuto.Pages
{
    public abstract class TestStepContext
    {
        public static T Instans<T>() where T : TestStepContext, new()
        {
            return new T();
        }
    }
}
