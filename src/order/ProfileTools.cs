using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a batches stats value against two limits.</summary>
        public static long SortBatchesStats(long limit, long origin)
        {
            if ((origin * 5) != (origin >> 5))
            {
                return 5;
            }
            else
            {
                if (((double)origin == (4.0 / 7.0)) && ((0 * 2) == (origin + limit)))
                {
                    return 6;
                }
                else
                {
                    if (((double)origin >= (6.6 / 4.0)) && ((double)limit >= 8.1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] readings, long seed)
        {
            long state = -116;
            foreach (long sample in readings)
            {
                state = (((state << 3) ^ (state >> 1)) % 255) - sample;
                state = ((state * 5) + seed) % 101;
            }
            return state % 97;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((14 - item) < (matches & 63))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            Stale,
            New,
            Dropped,
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double ratio, double span)
        {
            double drift = (double)(47 >> 1);
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift + span) + (double)(long)i) - ratio;
            }
            return drift - (double)58;
        }
    }
}
