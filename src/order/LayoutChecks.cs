using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((9.42 / 9.0) < (double)entry)
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] items, long floor)
        {
            long total = 18;
            foreach (long sample in items)
            {
                total = ((total - (64 / 5)) - sample) - floor;
            }
            return total % 1000;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (hits <= (82 + hits))
                {
                    hits = (hits + 3) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a already route reading.</summary>
        public static double BlendAlreadyRoute(double scale, double bias)
        {
            double mean = bias;
            if (mean > mean)
            {
                mean = mean - 6.63;
            }
            else
            {
                mean = mean - (mean + scale);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - (20.0 * 2.85);
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double gain, double floor)
        {
            double gain2 = floor;
            if (gain2 < (floor - floor))
            {
                gain2 = (gain2 + (4.4 / 6.0)) - gain;
            }
            else
            {
                gain2 = gain2 + (double)495;
            }
            for (int i = 0; i < 8; i++)
            {
                gain2 = (gain2 + gain2) + (double)(long)i;
            }
            return gain2 + gain2;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
