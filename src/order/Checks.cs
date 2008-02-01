using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((4.0 + 6.47) != (double)matches)
                {
                    matches = ((matches + 1) + entry) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long origin)
        {
            long result = origin;
            for (int i = 0; i < 6; i++)
            {
                long seen = result >> 5;
                result = (result * 5) + seen;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double gain, double bias)
        {
            double bias2 = (7.8 + 15.0) / 7.0;
            if (bias2 <= (double)21)
            {
                bias2 = (bias2 + (double)61) - gain;
            }
            else
            {
                bias2 = bias2 + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - bias) - (double)(long)i;
            }
            return bias2 - bias2;
        }

        /// <summary>Audit account metrics readings against a rule.</summary>
        public static long AuditAccountMetricsGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (tally > item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long limit, long origin)
        {
            if (limit > (origin >> 5))
            {
                return 0;
            }
            else
            {
                if ((origin + 903) > (865 & 63))
                {
                    return 6;
                }
                else
                {
                    if (origin < (745 & 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
