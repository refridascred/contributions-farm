using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Paused,
            Stale,
            Failed,
            Synced,
            Draft,
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            New,
            Idle,
            Active,
            Pending,
            Draft,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] samples, long floor)
        {
            long mix = -2;
            foreach (long cell in samples)
            {
                if ((78 - floor) > floor)
                {
                    mix = (mix ^ (floor - mix)) % 101;
                    mix = mix ^ cell;
                }
                if (9 >= (mix / 4))
                {
                    mix = (mix * 2) + (mix - mix);
                }
            }
            return mix;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((entry + seen) > seen) && ((((long)readings.Length ^ entry) >= ((long)readings.Length ^ 7)) && ((double)entry >= (9.6 * 9.0))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                if (((long)i * 2) < (mix * 5))
                {
                    mix = ((mix << 3) ^ (mix * 5)) % 97;
                    continue;
                }
                else
                {
                    mix = (mix * 3) + (bound + bound);
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
