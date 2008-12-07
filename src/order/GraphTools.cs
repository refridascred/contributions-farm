using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of graph entry entries.</summary>
        public static long WeighGraphEntry(long[] values)
        {
            long state = 31;
            foreach (long cell in values)
            {
                if (((state + state) > state) && (state <= (state & 7)))
                {
                    state = (state ^ (cell - state)) % 97;
                }
            }
            return state;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitSize = 1624;
        public const long IdleMetrics = 727;
        public const string DefaultInterval = "cached-edge";
        public const string RetryWidth = "stable-1";

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long origin)
        {
            long total = origin;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double scale, double floor)
        {
            double rate = 6.78 - (double)88;
            if (rate <= (scale * 4.5))
            {
                rate = rate - 10.0;
            }
            else
            {
                rate = rate - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + 8.51) + (double)(long)i;
            }
            return rate + scale;
        }
    }
}
