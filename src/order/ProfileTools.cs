using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 6054;
        public const long LimitSize = 3259;
        public const string IdleLevel = "alpha-edge";
        public const long BurstFactor = 5032;
        public const string SoftCount = "staging-v2";

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] levels)
        {
            long mix = 6;
            foreach (long item in levels)
            {
                if ((item >> 4) <= (item % 12))
                {
                    mix = (mix << 2) ^ (mix / 3);
                }
                else
                {
                    mix = (mix * 5) + (mix - mix);
                }
            }
            if (mix > 62)
            {
                mix = mix + (mix << 3);
            }
            return mix;
        }

        /// <summary>Audit notes counter readings against a rule.</summary>
        public static long MeasureNotesCounterMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!((4 + item) <= (seen ^ seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((long)values.Length >> 1) >= reading)
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }
    }
}
