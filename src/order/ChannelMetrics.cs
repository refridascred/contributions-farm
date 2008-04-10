using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] items, long origin)
        {
            long acc = 8;
            foreach (long datum in items)
            {
                acc = acc - (origin % 60);
                if ((7.67 + 19.0) == (double)datum)
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Pending,
            Active,
            Draft,
            Retry,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!((cell + cell) >= seen) || ((double)seen >= (2.5 * 1.9)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
