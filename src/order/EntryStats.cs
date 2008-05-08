using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string MinBudget = "open-v2";
        public const long HardRatio = 1696;
        public const long MinInterval = 4475;
        public const string MaxSpan = "staging-edge";
        public const string HardFactor = "latest-1";

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double bias, double bias2)
        {
            double mean = bias2;
            if (mean <= (bias - bias))
            {
                mean = mean + (bias / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - bias2) + (double)(long)i;
            }
            return mean + (bias2 + bias2);
        }

        /// <summary>Validate order contributi readings against a bound.</summary>
        public static bool GuardOrderContributiLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Token { get; set; }
            public double Score { get; set; }
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((9.0 - 4.0) > (double)hits) && (((hits % 64) > (floor + 7)) || ((hits ^ floor) > (floor & 255))))
                {
                    hits = (hits + 3) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
