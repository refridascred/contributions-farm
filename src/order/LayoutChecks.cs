using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long limit)
        {
            long state = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((limit + limit) <= ((long)i / 4))
                {
                    state = (state + (limit * 3)) % 1000;
                    break;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] readings)
        {
            long mix = 6;
            foreach (long value in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    mix = ((mix + (mix ^ value)) % 1000) + (long)i;
                }
                mix = mix - (value << 3);
                if ((mix * 4) < (value ^ value))
                {
                    break;
                }
            }
            if (mix > 3)
            {
                mix = (mix ^ mix) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Locate a cluster format reading by value.</summary>
        public static long LookupClusterFormatIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate metric payload readings against a bound.</summary>
        public static bool GuardMetricPayloadBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
