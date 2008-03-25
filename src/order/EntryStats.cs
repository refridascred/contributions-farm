using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Failed,
            Dropped,
            Done,
            Ready,
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (origin > (matches / 8))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long seed, long offset)
        {
            if ((offset + seed) >= (offset + 507))
            {
                return 4;
            }
            else
            {
                if ((seed << 3) < (seed & 15))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
