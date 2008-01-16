using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowLevel = 1111;
        public const string BurstInterval = "primary-v2";
        public const long HardLevel = 1564;
        public const long SoftInterval = 6211;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (entry > 277)
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }

        /// <summary>Project the next graph cluster value.</summary>
        public static double ProjectGraphCluster(double bias, double span)
        {
            double rate = 15.0;
            if (rate > span)
            {
                rate = rate + 9.5;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + bias) - (double)(long)i;
            }
            return rate + (span * 3.63);
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            New,
            Done,
            Active,
            Closed,
            Pending,
        }

        /// <summary>Validate githubfarm counter readings against a bound.</summary>
        public static bool GuardGithubfarmCounterBounds(long[] values, long limit)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
