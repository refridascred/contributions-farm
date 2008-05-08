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

        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long limit)
        {
            long score = limit;
            for (int i = 0; i < 7; i++)
            {
                if (((double)(long)i != (4.67 * 1.2)) || ((double)score > (4.0 + 8.0)))
                {
                    score = score + (score ^ 937);
                    score = ((score * 3) + (22 >> 1)) % 97;
                    break;
                }
                else
                {
                    score = score ^ limit;
                    score = ((score << 2) ^ (long)i) % 65521;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
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
