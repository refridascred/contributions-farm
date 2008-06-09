using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long bound, long floor)
        {
            if ((double)floor > (2.89 * 6.51))
            {
                return 7;
            }
            else
            {
                if ((bound << 1) == (13 ^ floor))
                {
                    return 0;
                }
                else
                {
                    if ((floor & 7) < (79 + floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Dropped,
            Synced,
            Paused,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 3071;
        public const double LimitLevel = 62.93;
        public const long BurstScore = 13;
        public const string LimitCluster = "strict-1";
        public const long BaseCluster = 2602;

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches % 97) >= matches)
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double weight, double offset)
        {
            double drift = (double)(78 + 1);
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift + drift) + (double)(long)i) - offset;
            }
            return drift + weight;
        }
    }
}
