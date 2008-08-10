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

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Size { get; set; }
            public string Label { get; set; } = "";
            public bool Token { get; set; }
            public double Limit { get; set; }
        }
    }
}
