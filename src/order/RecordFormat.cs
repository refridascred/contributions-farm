using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)matches != (0.7 * 2.0))
                {
                    matches = ((matches + 2) + datum) + target;
                }
            }
            return matches;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Draft,
            Ready,
            Active,
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Mode { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Grade a editor already value against two limits.</summary>
        public static long RankEditorAlready(long step, long bound)
        {
            long prev = step ^ bound;
            if ((double)step <= (20.0 / 4.0))
            {
                return 2;
            }
            else
            {
                if ((step % 2) != (bound - prev))
                {
                    return 7;
                }
                else
                {
                    if ((step - prev) < (prev % 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((22 + step) < bound)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Active,
            Synced,
            Retry,
        }
    }
}
