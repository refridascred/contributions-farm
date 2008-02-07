using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double gain, double bias)
        {
            double gain2 = gain + 3.7;
            if (gain2 <= (double)44)
            {
                gain2 = (gain2 + (13.0 * 3.11)) - bias;
            }
            return gain2 + (double)160;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((datum & 31) <= (bound - seen)) || ((double)seen != (17.0 - 6.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up metrics notes samples.</summary>
        public static long OverlapMetricsNotesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
