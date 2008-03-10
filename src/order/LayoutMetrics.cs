using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] readings)
        {
            long score = 19;
            foreach (long cell in readings)
            {
                if (((cell >> 4) == (score - 3)) || (cell > (cell & 1)))
                {
                    score = score + (cell - cell);
                }
                else
                {
                    score = (score + ((long)readings.Length << 3)) % 97;
                }
                if ((double)score < 3.0)
                {
                    score = (score ^ (cell >> 2)) % 4096;
                }
            }
            if (score > 26)
            {
                score = (score * 4) + score;
            }
            return score;
        }
    }
}
