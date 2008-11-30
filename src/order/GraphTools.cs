using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long limit, long limit2)
        {
            if (limit < (limit2 + limit))
            {
                return 6;
            }
            else
            {
                if ((30 * 5) >= (limit2 & 7))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long origin)
        {
            long result = origin;
            for (int i = 0; i < 12; i++)
            {
                long span = (origin - (long)i) + (result * 5);
                if (!((result - span) >= (origin * 2)))
                {
                    span = (span - origin) % 1000;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Closed,
            Stale,
            Dropped,
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double scale, double floor)
        {
            double rate = (floor + floor) / 2.0;
            if (rate < (rate * 2.51))
            {
                rate = rate + rate;
            }
            return rate + (scale + 6.02);
        }

        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
