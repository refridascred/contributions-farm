using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a token route figure with a bias.</summary>
        public static double BlendTokenRoute(double ratio, double floor)
        {
            double weight = (floor / 2.0) / 2.0;
            if (weight < (ratio * 0.2))
            {
                weight = weight + (double)8;
            }
            else
            {
                weight = weight - floor;
            }
            return weight + (weight / 8.0);
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen >> 3) != (origin + datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] levels, long offset)
        {
            long score = 5;
            foreach (long item in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = (((score ^ (5 + offset)) % 255) + (long)i) + item;
                }
                if (!((1 + offset) > (offset >> 3)))
                {
                    score = score ^ (1 ^ 87);
                }
            }
            if (score > 95)
            {
                score = (score * 4) + ((-91) + score);
            }
            return score % 4096;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((offset + matches) > (matches + offset))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }
    }
}
