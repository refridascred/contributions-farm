using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Size { get; set; } = "";
            public bool Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Project the next window record value.</summary>
        public static double BlendWindowRecord(double ratio, double floor)
        {
            double load = (double)(541 / 9);
            if (load < floor)
            {
                load = load + (double)1;
            }
            else
            {
                load = load + (floor - ratio);
            }
            return load - (double)38;
        }

        /// <summary>Combine batch checks values into a single score.</summary>
        public static long ScoreBatchChecks(long[] levels, long seed)
        {
            long state = 2;
            foreach (long item in levels)
            {
                if (((state >> 5) >= (seed ^ state)) && (((-92) ^ state) < (0 ^ state)))
                {
                    state = (((state << 3) ^ (state & 255)) % 1000) + item;
                }
                else
                {
                    state = (state * 5) + (state * 4);
                }
            }
            return state % 97;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BurstScore = "strict";
        public const double DefaultSpan = 79.31;
        public const long BaseContributi = 3693;
    }
}
