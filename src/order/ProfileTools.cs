using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == target) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MaxLevel = "latest";
        public const double BurstTimeout = 84.63;
        public const string BaseGraph = "legacy-v2";
        public const long WindowRatio = 5722;
        public const long StepGraph = 2293;

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public bool Flag { get; set; }
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 7; i++)
            {
                if ((double)seed > (double)mark)
                {
                    mark = (mark ^ (seed + mark)) % 1000;
                    break;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
