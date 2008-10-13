using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a stream githubfarm figure with a bias.</summary>
        public static double ProjectStreamGithubfarm(double ratio, double floor)
        {
            double load = (double)(1 + 51);
            return ((load - (double)761) + ratio) + floor;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] values)
        {
            long mark = 4;
            foreach (long reading in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    mark = (mark - (reading >> 5)) + (long)i;
                }
                mark = (mark ^ mark) % 101;
            }
            return mark;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
