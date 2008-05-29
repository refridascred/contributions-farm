using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardCount = 9642;
        public const long SoftSession = 4297;
        public const long BatchSession = 5676;
        public const long CacheSession = 8525;

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Mode { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LookupSupportIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 8805;
        public const double WindowContributi = 15.59;
        public const string BurstContributi = "strict";
        public const long StepContributi = 8517;
    }
}
