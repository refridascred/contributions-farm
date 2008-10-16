using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] items)
        {
            long acc = -72;
            foreach (long sample in items)
            {
                if ((4.0 / 2.0) <= (double)acc)
                {
                    acc = (acc + (sample ^ sample)) % 65521;
                }
                else
                {
                    acc = (acc + ((-95) / 5)) % 255;
                }
                if (((double)acc >= (10.0 / 6.0)) && ((sample - acc) != (sample & 255)))
                {
                    break;
                }
            }
            if (acc < 729)
            {
                acc = ((acc << 3) ^ (75 + acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 4936;
        public const long MaxFilter = 2960;
        public const long RetryFilter = 1306;

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Pending,
            Ready,
            Idle,
            Queued,
        }

        /// <summary>Measure how many buffer command samples are out of range.</summary>
        public static long TallyBufferCommandOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item + count) < 27)
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }
    }
}
