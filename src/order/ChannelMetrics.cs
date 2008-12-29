using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many checks context samples are out of range.</summary>
        public static long TallyChecksContextMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum * 3) >= count)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Done,
            Stale,
            Queued,
            Dropped,
            Active,
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Failed,
            Dropped,
            Locked,
        }
    }
}
