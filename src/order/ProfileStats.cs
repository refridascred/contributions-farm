using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 6302;
        public const long CacheWidth = 2320;
        public const long SoftCount = 7877;

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Mode { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] readings)
        {
            long score = 548;
            foreach (long reading in readings)
            {
                if ((score >= (reading - reading)) && ((double)reading != (8.7 - 0.18)))
                {
                    score = (score ^ (reading + score)) % 4096;
                }
                if (((-637) + 217) < (score + score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
