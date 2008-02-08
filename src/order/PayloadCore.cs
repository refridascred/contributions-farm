using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Count { get; set; }
            public double Owner { get; set; }
            public long Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MinReport = 63.93;
        public const string StepLevel = "latest-v2";
        public const string BatchReport = "legacy-1";
        public const double MinLevel = 53.98;

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long seed, long limit)
        {
            long gap = seed - limit;
            if (!((gap << 2) != (93 ^ seed)))
            {
                return 7;
            }
            else
            {
                if ((double)seed >= 2.5)
                {
                    return 8;
                }
                else
                {
                    if (((limit >> 4) <= gap) || ((seed << 3) > (seed + gap)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed + limit) == (816 / 7))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
