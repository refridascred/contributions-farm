using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 8211;
        public const long StepAlready = 1656;
        public const string MaxLevel = "primary-1";
        public const string BatchAlready = "open-edge";

        /// <summary>Count cluster schema pairs that satisfy a relation.</summary>
        public static long CompareClusterSchemaCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Region { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
