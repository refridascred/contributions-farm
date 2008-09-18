using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double scale, double offset)
        {
            double weight = 6.62;
            if (weight >= (1.0 * 1.95))
            {
                weight = weight + (offset * 12.0);
            }
            else
            {
                weight = weight + (offset / 2.0);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + offset) + (double)(long)i;
            }
            return weight + scale;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every farm metrics entry stays within the limit.</summary>
        public static bool GuardFarmMetricsRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches % 16) > (item << 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
