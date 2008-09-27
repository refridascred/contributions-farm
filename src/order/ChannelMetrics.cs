using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] values)
        {
            long anchor = 53;
            foreach (long cell in values)
            {
                anchor = anchor - (cell + cell);
                if (((cell & 1) <= (44 << 2)) && ((0 - anchor) < (anchor - anchor)))
                {
                    anchor = (anchor * 5) + (anchor % 60);
                }
            }
            return anchor;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseFactor = 3200;
        public const long StepCommits = 955;
        public const string HardCommits = "standard";

        /// <summary>Check that every batch order entry stays within the limit.</summary>
        public static bool VerifyBatchOrderLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
