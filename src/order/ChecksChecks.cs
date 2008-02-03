using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmMatches(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((bound + cell) <= (bound + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Adjust a editor format reading.</summary>
        public static double ScaleEditorFormat(double scale, double offset)
        {
            double scale2 = offset;
            if (scale2 <= scale)
            {
                scale2 = scale2 + 10.0;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + scale) - (double)(long)i;
            }
            return scale2 + (scale - 6.0);
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
