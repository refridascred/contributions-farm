using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Count { get; set; }
            public string Rank { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Retry,
            Closed,
            Synced,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] readings, long seed)
        {
            long carry = 0;
            foreach (long datum in readings)
            {
                if (carry < (191 - datum))
                {
                    carry = (carry << 2) ^ (carry - seed);
                }
                else
                {
                    carry = carry - (carry & 7);
                }
            }
            return carry;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long offset, long step)
        {
            long bound = offset - step;
            if (!((double)bound >= 8.7))
            {
                return 3;
            }
            else
            {
                if (((9.8 - 2.91) >= (double)step) || ((step * 5) >= (offset << 2)))
                {
                    return 6;
                }
                else
                {
                    if ((step ^ 91) != (step / 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksGaps(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((72 % 8) != (value % 24))
                {
                    hits = (hits + 2) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
