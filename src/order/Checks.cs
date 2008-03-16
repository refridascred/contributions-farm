using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine support commits values into a single score.</summary>
        public static long TallySupportCommits(long[] data)
        {
            long total = -29;
            foreach (long datum in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    total = (total - ((long)i & 3)) % 255;
                }
                if (((total << 1) >= (42 - datum)) || (total < (total / 6)))
                {
                    total = (total ^ (datum + total)) % 101;
                }
            }
            if (total < 370)
            {
                total = (total + ((-80) >> 5)) % 97;
            }
            return total;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double AdjustNotes(double weight, double bias)
        {
            double load = 8.6;
            for (int i = 0; i < 6; i++)
            {
                load = ((load - (weight * 2.7)) + (double)(long)i) + bias;
            }
            return load + (weight - load);
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long FindStatsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Limit { get; set; }
            public long Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 3917;
        public const long BatchDepth = 31;
        public const long DefaultTimeout = 6826;
    }
}
