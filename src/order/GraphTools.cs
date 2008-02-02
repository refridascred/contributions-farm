using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] values, long step)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit metric cache readings against a rule.</summary>
        public static long MeasureMetricCacheGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (hits > (floor & 63))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((origin >> 4) <= tally)
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long origin)
        {
            long score = origin;
            for (int i = 0; i < 14; i++)
            {
                score = ((score << 3) ^ (origin % 60)) % 97;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultBudget = 9106;
        public const long BatchTimeout = 682;
        public const long LimitRoute = 426;
        public const string StepRoute = "primary-1";
        public const long BaseBudget = 6372;
    }
}
