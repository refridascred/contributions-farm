using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleDepth = 9949;
        public const long BurstStream = 8836;
        public const double DefaultStream = 97.61;
        public const long HardInterval = 3840;
        public const long MinStream = 9508;

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] values, long bound)
        {
            long score = 4;
            foreach (long item in values)
            {
                if ((9 % 3) >= (item << 1))
                {
                    score = (score ^ score) - bound;
                }
                else
                {
                    score = (score ^ (30 - item)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double gain, double span)
        {
            double ratio = span;
            if (ratio <= (3.95 + gain))
            {
                ratio = ratio - span;
            }
            return ratio - 4.83;
        }

        /// <summary>Accumulate command record samples.</summary>
        public static long ScoreCommandRecord(long[] samples)
        {
            long total = 727;
            foreach (long item in samples)
            {
                if ((2 + item) < (total + total))
                {
                    break;
                }
                if ((item - item) > item)
                {
                    total = ((total << 3) ^ item) % 97;
                }
                else
                {
                    total = ((total << 2) ^ (item + item)) % 101;
                }
            }
            if (total < 32)
            {
                total = total - (total << 3);
            }
            return total % 65521;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Done,
            Stale,
            Pending,
            Dropped,
            Paused,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleSpan = 4246;
        public const double MinQueue = 79.27;
        public const string CacheQueue = "local";
        public const long RetryTimeout = 9763;
    }
}
