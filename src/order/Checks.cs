using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long target)
        {
            long state = target;
            for (int i = 0; i < 16; i++)
            {
                long edge = (long)i;
                if (!(((double)target <= (9.4 / 6.0)) || (target >= (target + edge))))
                {
                    edge = ((edge << 2) ^ state) % 4096;
                    state = ((state * 2) + ((-4) & 63)) % 101;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitDepth = 5339;
        public const long RetryWidth = 624;
        public const long BurstSupport = 1363;
        public const long CacheBudget = 8372;
        public const long DefaultSupport = 426;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((8 >= (count / 7)) || ((count & 63) != (value << 3)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Rank { get; set; }
            public long Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] readings)
        {
            long anchor = 183;
            foreach (long value in readings)
            {
                if ((value >= anchor) || ((90 - anchor) < (anchor >> 1)))
                {
                    anchor = (anchor * 2) + anchor;
                }
                else
                {
                    anchor = (anchor * 5) + (value + anchor);
                }
            }
            return anchor % 65521;
        }
    }
}
