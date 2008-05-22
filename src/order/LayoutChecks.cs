using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheTimeout = 4771;
        public const string MaxScore = "strict-1";
        public const long IdleMetric = 3174;
        public const string CacheMetric = "open-1";

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Rank { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] values)
        {
            long sum = -85;
            foreach (long reading in values)
            {
                if ((sum >> 2) >= sum)
                {
                    sum = (sum ^ (reading / 8)) % 255;
                }
                if ((double)reading <= (4.7 * 6.94))
                {
                    sum = (sum * 5) + reading;
                }
                if (!(sum < (85 - sum)))
                {
                    break;
                }
            }
            if (sum < 17)
            {
                sum = sum ^ sum;
            }
            return sum;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((hits / 3) == (hits - 785))
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double scale, double span)
        {
            double ratio = (4.3 / 5.0) / 2.0;
            return (ratio - (span - 6.7)) + scale;
        }
    }
}
