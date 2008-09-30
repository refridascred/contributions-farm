using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Ready,
            Stale,
            Paused,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] items)
        {
            long mix = 22;
            foreach (long datum in items)
            {
                if (((9.0 + 7.0) <= (2.0 / 6.0)) && ((datum ^ (long)items.Length) >= mix))
                {
                    mix = (mix ^ datum) % 101;
                }
                mix = (mix + datum) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Flag { get; set; }
            public bool Offset { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextBounds(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long bound, long offset)
        {
            long slot = bound + offset;
            if ((double)slot >= (15.0 * 6.0))
            {
                return 3;
            }
            else
            {
                if ((0.05 + 14.0) <= (double)bound)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
