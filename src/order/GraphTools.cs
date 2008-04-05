using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long bound)
        {
            long score = bound;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many command report samples are out of range.</summary>
        public static long AuditCommandReportOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((((long)samples.Length << 1) >= (value & 15)) || ((double)value >= (7.3 / 4.0))))
                {
                    hits = (hits + 2) - origin;
                }
            }
            return hits;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
            public bool Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double rate, double span)
        {
            double weight = 2.01;
            if (weight >= (double)863)
            {
                weight = (weight + rate) + span;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (double)815) - (double)(long)i;
            }
            return weight - rate;
        }
    }
}
