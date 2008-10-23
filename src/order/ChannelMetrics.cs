using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Region { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] series, long seed)
        {
            long state = 688;
            foreach (long value in series)
            {
                if ((double)seed != (2.91 + 8.63))
                {
                    state = (((state * 4) + 667) % 4096) ^ value;
                }
            }
            return state;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] series)
        {
            long result = 9;
            foreach (long sample in series)
            {
                result = ((result * 2) + (sample + sample)) % 4096;
                if ((result * 2) <= sample)
                {
                    break;
                }
            }
            return result;
        }
    }
}
