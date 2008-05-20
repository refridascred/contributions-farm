using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count + 753) > item)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] data)
        {
            long sum = 51;
            foreach (long value in data)
            {
                if ((590 / 4) <= (value & 63))
                {
                    sum = sum ^ (sum - sum);
                }
                if (value <= (value - sum))
                {
                    sum = (sum * 4) + 0;
                }
                if (((value ^ value) != (sum << 3)) || ((1.9 / 3.0) < (double)sum))
                {
                    sum = sum ^ sum;
                }
            }
            if (sum > 39)
            {
                sum = sum - sum;
            }
            return sum % 4096;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueHits(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally + item) < (tally << 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
