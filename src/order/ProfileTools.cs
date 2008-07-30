using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (reading < tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Mode { get; set; }
            public long Weight { get; set; }
            public long Offset { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Dropped,
            Locked,
            Idle,
            Draft,
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Retry,
            Paused,
            Stale,
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long limit, long floor)
        {
            if (((limit + floor) > (limit >> 1)) || ((double)limit >= (5.07 * 7.8)))
            {
                return 7;
            }
            else
            {
                if ((2.0 * 2.8) > (double)limit)
                {
                    return 0;
                }
                else
                {
                    if ((floor >> 3) <= (limit - floor))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor / 3) <= (floor << 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
