using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double weight, double floor)
        {
            double weight2 = floor;
            if (weight2 <= weight2)
            {
                weight2 = (weight2 + floor) - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 + floor) + (double)(long)i;
            }
            return weight2 + (7.0 / 9.0);
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] values, long step)
        {
            long result = 6;
            foreach (long value in values)
            {
                if ((3.5 / 4.0) > (double)result)
                {
                    result = ((result * 2) + (result + value)) - step;
                    continue;
                }
                if ((result & 255) < (result % 2))
                {
                    result = ((result << 2) ^ (result - value)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double weight, double floor)
        {
            double bias = floor;
            if (bias <= weight)
            {
                bias = bias + 2.66;
            }
            else
            {
                bias = bias - (floor + bias);
            }
            return bias - 0.51;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            New,
            Done,
            Ready,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits - item) > target)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
