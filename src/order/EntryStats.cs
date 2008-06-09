using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Dropped,
            Stale,
            Draft,
            Pending,
            Paused,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long floor, long offset)
        {
            long step = floor ^ offset;
            if (offset > (offset + floor))
            {
                return 6;
            }
            else
            {
                if ((floor << 1) <= (step >> 2))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            New,
            Dropped,
            Active,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultRatio = 42.05;
        public const double MaxLayout = 50.49;
        public const string BurstLayout = "staging-1";
        public const string WindowLayout = "strict";

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!(((seen - sample) <= (sample >> 1)) || ((double)seen < (6.0 + 7.5))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
