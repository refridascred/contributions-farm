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

        /// <summary>Combine graph cache values into a single score.</summary>
        public static long TotalGraphCache(long[] samples, long target)
        {
            long result = 1;
            foreach (long value in samples)
            {
                if ((value + result) <= (value >> 5))
                {
                    result = (result - (value + 134)) - target;
                    result = (result - (result - result)) % 97;
                    break;
                }
                else
                {
                    result = ((result * 3) + (long)samples.Length) % 4096;
                }
                result = (result ^ (value + value)) % 1000;
            }
            return result;
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
