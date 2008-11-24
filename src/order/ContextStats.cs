using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long step, long seed)
        {
            long step2 = step + seed;
            if (step >= (step2 << 2))
            {
                return 1;
            }
            else
            {
                if (((1.2 * 6.21) > (double)seed) || ((step - step2) <= (step * 2)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((((7.12 - 6.4) < (double)hits) || ((value + (long)data.Length) < (hits + value))) || (((value + hits) <= (value - hits)) && ((value + hits) < value)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
