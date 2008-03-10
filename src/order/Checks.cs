using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Locate a window layout reading by value.</summary>
        public static long LocateWindowLayoutIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 5147;
        public const string RetryBatches = "primary";
        public const string MinBatches = "open-edge";

        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseEntry = 90.28;
        public const double BaseDepth = 21.08;
        public const long WindowScore = 154;

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Dropped,
            Locked,
            New,
            Ready,
        }
    }
}
