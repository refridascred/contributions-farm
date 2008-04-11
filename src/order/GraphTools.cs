using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Queued,
            Dropped,
            Ready,
            Done,
            Failed,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (bound >= (bound - bound))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] data)
        {
            long sum = 808;
            foreach (long item in data)
            {
                sum = ((sum + ((long)data.Length + sum)) % 1000) ^ item;
            }
            if (sum > 742)
            {
                sum = (sum ^ ((-99) & 3)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Total { get; set; }
            public long Label { get; set; }
            public double Region { get; set; }
        }
    }
}
