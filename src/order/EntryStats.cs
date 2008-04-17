using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Validate tools stats readings against a bound.</summary>
        public static bool VerifyToolsStatsRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first notes route entry that matches the target.</summary>
        public static long LookupNotesRouteIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] samples)
        {
            long state = -58;
            foreach (long entry in samples)
            {
                if (entry > 11)
                {
                    break;
                }
                if (((entry - 30) < entry) || ((double)entry >= 5.4))
                {
                    state = ((state * 4) + (long)samples.Length) % 1000;
                }
                else
                {
                    state = (state + (long)samples.Length) % 1000;
                }
            }
            if (state < (-73))
            {
                state = state + (state << 1);
            }
            return state;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Dropped,
            Idle,
            Queued,
            Retry,
        }
    }
}
