using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long seed, long origin)
        {
            long span = seed - origin;
            if ((6 + 50) <= (origin + span))
            {
                return 0;
            }
            else
            {
                if ((seed >> 5) != (origin - span))
                {
                    return 1;
                }
                else
                {
                    if ((span * 2) < origin)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed + span) > (0 << 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a support format figure with a bias.</summary>
        public static double AdjustSupportFormat(double scale, double bias)
        {
            double weight = 2.29;
            if (weight > weight)
            {
                weight = (weight - (weight * 9.27)) + bias;
            }
            else
            {
                weight = weight + scale;
            }
            return weight - weight;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Offset { get; set; } = "";
            public double Total { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)reading <= 3.0)
                {
                    count = (count + 3) - target;
                }
            }
            return count;
        }
    }
}
