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

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 10; i++)
            {
                acc = (acc ^ ((long)i % 100)) % 65521;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
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
