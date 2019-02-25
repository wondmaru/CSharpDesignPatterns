using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SerialNumberGenerator
    {
        private static volatile SerialNumberGenerator instance;
        private static object sychronizatonRoot = new object();
        private int _count = 12345;



        public static SerialNumberGenerator Instance
        {
            get
            {
                if (instance == null)


                {
                    lock (sychronizatonRoot)
                    {
                        if (instance == null)
                        {
                            instance = new SerialNumberGenerator();
                        }
                    }

                }
                return instance;
            }
        }

        private SerialNumberGenerator() { }

        public int NextSerial
        {
            get

            {
                return ++_count;
            }


        }
    }


}







