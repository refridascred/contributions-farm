using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long bound, long seed)
        {
            if (bound > (499 * 2))
            {
                return 6;
            }
            else
            {
                if ((1.65 / 6.0) < (double)bound)
                {
                    return 3;
                }
                else
                {
                    if (((6.0 * 20.0) <= (double)seed) && ((bound ^ seed) < (seed - seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (bound > (9 + seed))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Size { get; set; }
            public long Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstNotes = "staging-v2";
        public const double HardSpan = 60.38;
        public const double SoftNotes = 55.22;
        public const long BurstSize = 3680;

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] items)
        {
            long anchor = -76;
            foreach (long sample in items)
            {
                long gap = sample << 2;
                anchor = anchor + (gap - anchor);
                if (783 < (anchor << 1))
                {
                    anchor = (anchor << 3) ^ anchor;
                }
            }
            return anchor;
        }
    }
}
