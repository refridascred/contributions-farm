using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long offset, long bound)
        {
            long edge = offset - bound;
            if (!(bound < (879 ^ (-300))))
            {
                return 3;
            }
            else
            {
                if ((edge - 0) != (offset << 3))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen + cell) > (seen * 3))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long step, long target)
        {
            if (((8 >> 5) >= (target ^ step)) || ((step - step) > step))
            {
                return 0;
            }
            else
            {
                if ((step - 960) < target)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Stale,
            Pending,
            Active,
            Idle,
            Retry,
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Score { get; set; }
            public double Owner { get; set; }
        }
    }
}
