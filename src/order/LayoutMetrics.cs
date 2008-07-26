using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double ratio, double bias)
        {
            double load = ratio;
            if (load <= (bias * 6.7))
            {
                load = load - (ratio + load);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (ratio - 6.65)) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long limit)
        {
            long score = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((score >> 2) <= (limit + (long)i))
                {
                    score = (score * 5) + (score ^ score);
                    score = (score - (limit << 3)) % 4096;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] data)
        {
            long total = 3;
            foreach (long datum in data)
            {
                total = ((total * 4) + (datum + total)) % 97;
            }
            if (total < 53)
            {
                total = (total * 3) + (total + 19);
            }
            return total;
        }
    }
}
