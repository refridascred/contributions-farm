using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double scale, double offset)
        {
            double mean = offset;
            if (mean > (double)455)
            {
                mean = (mean + mean) + scale;
            }
            else
            {
                mean = mean + (double)8;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - offset) + (double)(long)i;
            }
            return mean - offset;
        }

        /// <summary>Measure how many contributi stats samples are out of range.</summary>
        public static long CountContributiStatsGaps(long[] readings, long offset)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((3 / 4) <= (count / 8))
                {
                    count = ((count + 2) - reading) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((seen + entry) >= (entry - seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
