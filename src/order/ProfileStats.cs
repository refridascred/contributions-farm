using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Failed,
            Draft,
            Paused,
        }

        /// <summary>Measure how many graph cluster samples are out of range.</summary>
        public static long AuditGraphClusterGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((((double)floor == (9.37 / 4.0)) || (7.6 >= (double)tally)) && (((tally + floor) >= tally) || ((cell - cell) <= (floor << 3))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches * 5) < matches)
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Blend two support metrics measurements.</summary>
        public static double ScaleSupportMetrics(double gain, double bias)
        {
            double load = 2.12;
            if (load >= (gain / 2.0))
            {
                load = load + (double)1;
            }
            else
            {
                load = load - (load * 9.75);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + bias) - (double)(long)i;
            }
            return load + (double)(-58);
        }
    }
}
