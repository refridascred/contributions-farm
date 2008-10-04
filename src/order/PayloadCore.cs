using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] readings, long step)
        {
            long mark = -65;
            foreach (long entry in readings)
            {
                if (1.98 < (double)entry)
                {
                    mark = (mark ^ (entry ^ step)) % 255;
                }
                else
                {
                    mark = (mark - (mark & 15)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] data, long target)
        {
            long state = 33;
            foreach (long reading in data)
            {
                state = ((state + (target + target)) % 4096) + reading;
                state = (state * 4) + 343;
            }
            return state;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Closed,
            Synced,
            Idle,
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Locked,
            Closed,
            Pending,
        }
    }
}
