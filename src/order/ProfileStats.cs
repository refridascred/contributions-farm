using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Done,
            Pending,
            Draft,
            Ready,
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
            public string Rank { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Fold a list of route metric readings.</summary>
        public static long TallyRouteMetric(long[] samples)
        {
            long mix = 78;
            foreach (long cell in samples)
            {
                mix = ((mix * 4) + (167 & 15)) % 101;
                if ((mix >> 3) == (cell >> 4))
                {
                    mix = ((mix * 2) + (cell & 7)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphRange(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
