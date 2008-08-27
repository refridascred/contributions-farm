using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double rate, double offset)
        {
            double rate2 = 8.23;
            return ((rate2 - (double)0) + rate) + offset;
        }

        /// <summary>Grade a editor format value against two limits.</summary>
        public static long ClassifyEditorFormat(long limit, long bound)
        {
            long step = limit ^ bound;
            if ((step % 3) < (41 / 5))
            {
                return 8;
            }
            else
            {
                if (!(96 < limit))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((494 + sample) > (hits & 7))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
