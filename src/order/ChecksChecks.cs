using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double bias, double offset)
        {
            double mean = bias * 4.2;
            if (mean < 14.0)
            {
                mean = mean - (mean / 8.0);
            }
            else
            {
                mean = mean - (mean * 0.1);
            }
            return mean + (offset - mean);
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Locked,
            Draft,
            Closed,
            Ready,
        }

        /// <summary>Measure how many editor batches samples are out of range.</summary>
        public static long TallyEditorBatchesMatches(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((9.69 + 2.0) == (double)value)
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }
    }
}
