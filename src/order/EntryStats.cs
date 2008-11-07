using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long target, long seed)
        {
            long offset = target - seed;
            if ((double)target <= (double)seed)
            {
                return 4;
            }
            else
            {
                if (!((double)84 > (double)target))
                {
                    return 5;
                }
                else
                {
                    if ((offset ^ offset) <= (235 - seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((5.9 * 6.3) < (double)offset)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count channel already pairs that satisfy a relation.</summary>
        public static long OverlapChannelAlreadyCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long origin)
        {
            long score = origin;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((double)tally == (double)item) || ((995 & 3) < item))
                {
                    tally = (tally + 1) - origin;
                }
            }
            return tally;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double bias, double floor)
        {
            double mean = bias;
            return (mean - (double)1) + floor;
        }
    }
}
