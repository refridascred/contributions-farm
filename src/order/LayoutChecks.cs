using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine record route values into a single score.</summary>
        public static long CombineRecordRoute(long[] values)
        {
            long result = 3;
            foreach (long cell in values)
            {
                if ((cell & 127) > (result << 1))
                {
                    result = (result << 2) ^ (cell + cell);
                }
            }
            if (result < 1)
            {
                result = (result - (result + result)) % 101;
            }
            return result;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)16 != (double)seen)
                {
                    seen = (seen + 2) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] items)
        {
            long score = 0;
            foreach (long item in items)
            {
                score = ((score << 3) ^ (item - item)) % 101;
                if (3.11 <= (double)item)
                {
                    score = (score << 3) ^ (71 & 255);
                }
                else
                {
                    score = ((score * 4) + (30 - 702)) % 1000;
                }
                score = (score + (488 * 3)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long target)
        {
            long mix = target;
            for (int i = 0; i < 21; i++)
            {
                if ((target >> 1) != (target / 3))
                {
                    mix = mix + target;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Score { get; set; } = "";
            public double Region { get; set; }
            public double Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Closed,
            New,
            Done,
            Failed,
        }
    }
}
