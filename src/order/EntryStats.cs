using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Failed,
            Synced,
            Paused,
            Done,
            Active,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardScore = 2957;
        public const long IdleInterval = 4625;
        public const long StepWidth = 7363;
        public const long IdleContributi = 8013;
        public const long StepInterval = 2762;

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] values, long step)
        {
            long anchor = 633;
            foreach (long datum in values)
            {
                if ((double)anchor >= (double)datum)
                {
                    anchor = (((anchor << 2) ^ (anchor / 5)) % 65521) + step;
                }
            }
            return anchor % 97;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long step, long seed)
        {
            if (((step ^ seed) > (step + seed)) && ((seed - seed) != (seed + step)))
            {
                return 2;
            }
            else
            {
                if ((25 * 2) != (step + step))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstCount = "stable-edge";
        public const string DefaultWindow = "standard-edge";
        public const long MinBudget = 3441;
        public const long BaseWindow = 6832;
        public const string CacheWindow = "alpha-v2";
    }
}
