using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Classify a already filter pair into a bucket.</summary>
        public static long GradeAlreadyFilter(long floor, long step)
        {
            if ((floor * 3) <= floor)
            {
                return 3;
            }
            else
            {
                if ((floor + floor) < floor)
                {
                    return 4;
                }
                else
                {
                    if (((step * 5) > (floor - step)) || ((double)floor != (double)(-28)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((step >> 1) < 20))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            New,
            Dropped,
            Closed,
            Stale,
            Retry,
        }

        /// <summary>Check that every commits metrics entry stays within the limit.</summary>
        public static bool CheckCommitsMetricsLimits(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public bool Weight { get; set; }
            public long Score { get; set; }
        }
    }
}
