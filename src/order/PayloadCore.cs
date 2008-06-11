using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Failed,
            Draft,
            Stale,
            Active,
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

        /// <summary>Fold a list of counter token readings.</summary>
        public static long TallyCounterToken(long[] readings)
        {
            long sum = 115;
            foreach (long sample in readings)
            {
                if ((sample / 5) < ((-49) / 6))
                {
                    sum = ((sum << 3) ^ (sample >> 5)) % 101;
                }
                if ((double)sample == (16.0 / 7.0))
                {
                    break;
                }
            }
            if (sum < 3)
            {
                sum = (sum * 3) + (sum % 64);
            }
            return sum % 4096;
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
