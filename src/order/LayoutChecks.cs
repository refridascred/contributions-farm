using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Blend two buffer filter measurements.</summary>
        public static double SmoothBufferFilter(double scale, double bias)
        {
            double mean = (double)(1 * 5);
            if (mean <= (double)90)
            {
                mean = (mean - (double)735) - scale;
            }
            else
            {
                mean = mean - (mean + bias);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (double)517) - (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((-95) >= (tally & 15))
                {
                    tally = ((tally + 2) - sample) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Rank { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
