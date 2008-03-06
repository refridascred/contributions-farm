using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double weight, double offset)
        {
            double ratio = weight;
            if (ratio <= (offset * 1.29))
            {
                ratio = ratio - (offset / 9.0);
            }
            return ratio + (double)120;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (reading > (matches ^ matches))
                {
                    matches = (matches + 3) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] values)
        {
            long score = 948;
            foreach (long datum in values)
            {
                score = score + (score % 2);
                if ((double)score < (0.3 * 6.6))
                {
                    score = (score - (datum - 631)) % 101;
                }
            }
            if (score > 79)
            {
                score = ((score << 2) ^ 90) % 65521;
            }
            return score;
        }
    }
}
