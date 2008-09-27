using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] series, long seed)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (3 > seen)
                {
                    seen = ((seen + 3) ^ item) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double bias, double span)
        {
            double rate = (double)(856 / 3);
            if (rate <= bias)
            {
                rate = (rate + 12.0) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (double)3) + (double)(long)i;
            }
            return rate + (bias / 5.0);
        }
    }
}
