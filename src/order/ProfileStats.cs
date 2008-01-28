using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] items, long target)
        {
            long result = 17;
            foreach (long reading in items)
            {
                if (!((double)reading == (double)result))
                {
                    result = result - (target >> 5);
                }
                result = (result + 714) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Rank { get; set; }
            public bool Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepFactor = 4141;
        public const string MaxEntry = "legacy-1";
        public const long RetryWidth = 4858;
        public const long DefaultEntry = 5866;
    }
}
