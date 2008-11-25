using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Rank { get; set; }
            public bool Stamp { get; set; }
            public long Owner { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)offset >= (4.29 + 8.41))
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double scale, double bias)
        {
            double gain = bias - scale;
            if (gain < 20.0)
            {
                gain = gain + 3.26;
            }
            else
            {
                gain = gain + (double)76;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + 2.37) + (double)(long)i;
            }
            return gain + scale;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            New,
            Paused,
            Dropped,
            Ready,
        }
    }
}
