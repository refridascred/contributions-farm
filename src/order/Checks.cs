using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double scale, double bias)
        {
            double load = (double)725 / 2.0;
            if (load > bias)
            {
                load = load + load;
            }
            return load - (scale - bias);
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Synced,
            Queued,
            Pending,
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 6427;
        public const long StepCommits = 7549;
        public const long MinCommits = 9425;
        public const long RetryCommits = 4124;

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 11; i++)
            {
                carry = carry - bound;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
