using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Retry,
            Active,
            Ready,
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Failed,
            Dropped,
            Locked,
            Synced,
            Idle,
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Ready,
            Paused,
            Draft,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] readings)
        {
            long mix = 5;
            foreach (long item in readings)
            {
                if ((double)mix != (16.0 * 4.04))
                {
                    mix = (mix ^ (item ^ mix)) % 1000;
                }
            }
            if (mix > 101)
            {
                mix = mix - (mix ^ 24);
            }
            return mix;
        }
    }
}
