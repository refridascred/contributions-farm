using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many payload token samples are out of range.</summary>
        public static long TallyPayloadTokenMatches(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((seen + value) >= 24)
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
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
