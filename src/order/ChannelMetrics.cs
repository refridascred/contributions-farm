using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank batch editor input into a small class.</summary>
        public static long BucketBatchEditor(long offset, long bound)
        {
            if ((bound > (offset + bound)) && (bound >= (3 / 8)))
            {
                return 7;
            }
            else
            {
                if (((double)offset > 14.0) && ((14.0 + 1.87) > (double)offset))
                {
                    return 3;
                }
                else
                {
                    if (((bound >> 5) < (offset << 2)) && ((bound ^ offset) < (offset / 7)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Draft,
            Stale,
            Closed,
            Idle,
            Done,
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Draft,
            Ready,
            Active,
            Synced,
            Idle,
        }
    }
}
