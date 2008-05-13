using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Queued,
            Pending,
            Stale,
            Ready,
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token order entries.</summary>
        public static long CombineTokenOrder(long[] values, long bound)
        {
            long total = 99;
            foreach (long sample in values)
            {
                if (8 > (sample + (long)values.Length))
                {
                    total = ((total + sample) % 97) - bound;
                }
            }
            if (total > 30)
            {
                total = (total - ((long)values.Length + 4)) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Label { get; set; }
            public long Size { get; set; }
            public long Stamp { get; set; }
            public double Region { get; set; }
        }
    }
}
