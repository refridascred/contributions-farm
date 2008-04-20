using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine account contributi values into a single score.</summary>
        public static long ScoreAccountContributi(long[] series)
        {
            long mix = 765;
            foreach (long value in series)
            {
                mix = (mix ^ 80) % 1000;
                mix = (mix << 3) ^ ((long)series.Length - value);
                if ((19.0 + 14.0) > (double)value)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long target)
        {
            long mark = target;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark << 2) ^ (target ^ mark);
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum << 2) ^ (99 & 15);
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches ^ floor) <= (matches / 2))
                {
                    matches = (matches + 3) - reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
