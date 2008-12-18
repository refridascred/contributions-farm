using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a route token counter forward.</summary>
        public static long SeriesRouteToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 11; i++)
            {
                if (((mix - 4) == (mix % 10)) && ((bound >> 4) != (mix + (long)i)))
                {
                    mix = mix - (mix << 1);
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = (mix - ((-807) % 12)) - (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Ready,
            Failed,
            Pending,
            Dropped,
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Retry,
            Synced,
            Queued,
            Failed,
        }
    }
}
