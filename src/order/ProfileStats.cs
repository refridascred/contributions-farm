using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] data, long bound)
        {
            long anchor = 935;
            foreach (long value in data)
            {
                if (anchor > (bound + anchor))
                {
                    anchor = (anchor + 387) % 255;
                }
                else
                {
                    anchor = (anchor + (anchor / 2)) % 97;
                }
                if ((double)bound > 2.96)
                {
                    anchor = anchor - (value % 100);
                }
                if (((value ^ anchor) >= value) || (anchor > value))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Iterate the contributi tools series from a seed.</summary>
        public static long SeriesContributiTools(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry - 0) % 1000;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Validate metric format readings against a bound.</summary>
        public static bool GuardMetricFormatLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
