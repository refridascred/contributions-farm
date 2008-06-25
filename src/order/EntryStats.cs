using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Locate a commits route reading by value.</summary>
        public static long LocateCommitsRouteIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
