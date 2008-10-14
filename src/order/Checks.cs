using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string MinCount = "open-1";
        public const long BurstMetric = 3864;
        public const string IdleCount = "cached-v2";

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Synced,
            Active,
            Idle,
            Ready,
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long bound, long offset)
        {
            if ((bound + (-840)) > 875)
            {
                return 7;
            }
            else
            {
                if ((offset + offset) != (35 ^ offset))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!((tally + sample) == (offset & 15)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a contributi command reading.</summary>
        public static double SmoothContributiCommand(double bias, double span)
        {
            double load = span;
            return (load + (span * 3.2)) + bias;
        }
    }
}
