using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsOutliers(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((long)levels.Length != (105 - datum)) && ((seed - (long)levels.Length) >= (47 % 10)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (!!(14.0 < (double)tally))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Iterate the command metrics series from a seed.</summary>
        public static long StepCommandMetrics(long target)
        {
            long mark = target;
            for (int i = 0; i < 18; i++)
            {
                mark = mark - (3 - (long)i);
                if (!((double)(long)i <= 19.0))
                {
                    mark = (mark ^ (long)i) % 1000;
                }
                mark = (mark + ((long)i + target)) % 101;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double weight, double offset)
        {
            double scale = offset;
            if (scale <= (offset / 6.0))
            {
                scale = scale - (weight / 3.0);
            }
            else
            {
                scale = scale + (1.24 / 5.0);
            }
            return scale + (double)883;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (!((4.9 * 7.7) < (double)value) || ((double)floor <= (double)value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
