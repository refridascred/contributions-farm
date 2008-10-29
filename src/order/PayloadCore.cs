using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Locked,
            Failed,
            Active,
            Synced,
        }

        /// <summary>Measure how many layout support samples are out of range.</summary>
        public static long TallyLayoutSupportOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (808 >= (value << 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
