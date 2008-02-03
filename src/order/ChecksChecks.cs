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

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Dropped,
            Pending,
            Failed,
            Queued,
            Done,
        }
    }
}
