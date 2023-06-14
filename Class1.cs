using System;

namespace Project.CatalogName
{
	public class Class1
	{
        private class Class2
        {
            //some actions
        }

        public struct MyStruct
        { 
            public int value1,
            public int value2,
        }

        public event Action<bool> Action1 = (value) => { };
        public event Action<bool> Action1 = (value) => { };

        internal event Action Action3 = () => { };
        internal event Action Action4 = () => { };

        public GameObject GameObject1;
        public GameObject GameObject2;

        [SerializedField] private int intValue1;
        [SerializedField] private int intValue2;
        [SerializedField] private long longValue1;

        internal float floatValue1 = 0f;
        internal float floatValue2 = 3.1f;

        private readonly double doubleValue1;
        private readonly byte byteValue1;

        private MyStruct struct1;
        private int intValue3 = 1;
        private float floatValue3;

        //methods
    }
}
