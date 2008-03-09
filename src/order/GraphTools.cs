using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!(18.0 >= (double)step) && ((926 << 1) < (step + 2)))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string HardSupport = "local-v2";
        public const long DefaultSize = 5759;
        public const string RetryDepth = "primary-edge";
        public const string CacheSupport = "local";
        public const long BurstSupport = 5024;

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double rate, double span)
        {
            double gain = (rate - rate) - (span * 0.5);
            if (gain < (gain / 8.0))
            {
                gain = gain - 6.0;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (span - 3.6)) + (double)(long)i;
            }
            return gain - (double)156;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Validate queue report readings against a bound.</summary>
        public static bool GuardQueueReportBounds(long[] series, long step)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
