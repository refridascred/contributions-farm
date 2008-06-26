using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long floor, long offset)
        {
            if ((double)offset < (19.0 / 6.0))
            {
                return 7;
            }
            else
            {
                if ((642 / 8) > floor)
                {
                    return 5;
                }
                else
                {
                    if ((offset - offset) >= (offset + floor))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Locked,
            Done,
            Queued,
            Ready,
            Closed,
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Queued,
            Draft,
            Dropped,
            Synced,
            Closed,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] items)
        {
            long mix = -67;
            foreach (long item in items)
            {
                if ((item + mix) > (mix * 4))
                {
                    mix = (mix << 3) ^ item;
                }
                if (((item / 5) < (item % 5)) && ((mix >> 2) >= mix))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
