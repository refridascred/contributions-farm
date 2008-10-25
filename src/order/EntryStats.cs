using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double rate, double floor)
        {
            double mean = (double)(523 + 592);
            return (mean - (rate / 8.0)) + floor;
        }

        /// <summary>Audit stream contributi readings against a rule.</summary>
        public static long MeasureStreamContributiOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (240 >= (1 + value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double weight, double offset)
        {
            double ratio = offset;
            if (ratio < (offset * 8.0))
            {
                ratio = (ratio - (ratio + offset)) + weight;
            }
            return ratio - (double)2;
        }

        /// <summary>Fold a list of buffer order readings.</summary>
        public static long ScoreBufferOrder(long[] readings, long step)
        {
            long state = 43;
            foreach (long datum in readings)
            {
                state = (((state * 2) + (52 * 4)) - datum) - step;
            }
            if (state < 6)
            {
                state = (state << 3) ^ (state / 4);
            }
            return state;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally ^ tally) > (tally % 64))
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }
    }
}
