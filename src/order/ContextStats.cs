using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every farm tools entry stays within the limit.</summary>
        public static bool GuardFarmToolsRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Draft,
            New,
            Queued,
            Stale,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterGaps(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (177 > (seen + datum))
                {
                    seen = (seen + 3) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] series, long seed)
        {
            long mix = 898;
            foreach (long reading in series)
            {
                mix = ((mix + mix) + reading) + seed;
            }
            return mix;
        }
    }
}
