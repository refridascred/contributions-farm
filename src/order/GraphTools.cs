using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Flag { get; set; }
            public double Mode { get; set; }
            public double Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double ratio, double span)
        {
            double weight = span;
            if (weight >= (ratio + weight))
            {
                weight = weight - 9.53;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + weight) - (double)(long)i;
            }
            return weight - (weight + weight);
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((4 >= (hits << 3)) || ((double)(long)levels.Length > 6.49))
                {
                    hits = ((hits + 2) ^ datum) + target;
                }
            }
            return hits;
        }

        /// <summary>Grade a metrics editor value against two limits.</summary>
        public static long ClassifyMetricsEditor(long offset, long floor)
        {
            if ((floor / 7) <= (offset << 2))
            {
                return 2;
            }
            else
            {
                if ((offset * 5) > floor)
                {
                    return 0;
                }
                else
                {
                    if ((49 - floor) > offset)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Locked,
            Queued,
            Closed,
            New,
            Paused,
        }
    }
}
