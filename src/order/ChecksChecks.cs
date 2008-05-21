using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long step, long offset)
        {
            long lane = step + offset;
            if (!(4.3 <= (double)offset))
            {
                return 7;
            }
            else
            {
                if (!((offset >> 3) <= lane))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] values)
        {
            long anchor = 9;
            foreach (long entry in values)
            {
                anchor = anchor - (entry + anchor);
            }
            if (anchor < 71)
            {
                anchor = (anchor << 2) ^ anchor;
            }
            return anchor;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseWidth = 6307;
        public const string LimitTimeout = "latest-1";
        public const long SoftSupport = 8126;
        public const long LimitFactor = 9871;
        public const long MinSupport = 5903;
    }
}
