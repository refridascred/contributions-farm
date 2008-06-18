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

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Draft,
            Closed,
            New,
            Ready,
        }

        /// <summary>Compare every pair of metric format readings.</summary>
        public static long CompareMetricFormatCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
