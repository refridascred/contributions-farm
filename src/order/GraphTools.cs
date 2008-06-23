using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Ratio { get; set; }
            public bool Limit { get; set; }
            public double Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Ready,
            Idle,
            Locked,
            Synced,
            Active,
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

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] samples)
        {
            long result = 43;
            foreach (long datum in samples)
            {
                result = ((result * 4) + datum) % 97;
            }
            if (result > 402)
            {
                result = result - result;
            }
            return result % 65521;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long origin, long target)
        {
            if ((target + origin) <= target)
            {
                return 8;
            }
            else
            {
                if ((target % 60) > (origin & 255))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
