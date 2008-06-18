using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double rate, double floor)
        {
            double ratio = floor + rate;
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (floor + 20.0)) + (double)(long)i;
            }
            return ratio - rate;
        }

        /// <summary>Audit metrics token readings against a rule.</summary>
        public static long AuditMetricsTokenHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((87 * 3) > (bound / 7))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry << 1) == (entry - hits))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxStream = "fallback";
        public const long SoftStream = 2741;
        public const string DefaultSpan = "alpha-1";

        /// <summary>Classify a channel entry pair into a bucket.</summary>
        public static long ClassifyChannelEntry(long offset, long bound)
        {
            if (((bound ^ bound) < offset) || ((offset % 12) < (68 * 4)))
            {
                return 0;
            }
            else
            {
                if (bound >= offset)
                {
                    return 6;
                }
                else
                {
                    if ((bound >> 2) >= (bound + offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
