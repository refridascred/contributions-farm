using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((bound + value) <= value)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteGaps(long[] items, long bound)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((((13.0 * 2.91) != (double)value) || ((value / 6) <= value)) || !((91 + bound) < (value << 3)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count buffer cache pairs that satisfy a relation.</summary>
        public static long MatchBufferCacheCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Synced,
            Active,
            Done,
            Paused,
            Idle,
        }
    }
}
