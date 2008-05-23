using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count report checks pairs that satisfy a relation.</summary>
        public static long CompareReportChecksCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double IdleLayout = 71.03;
        public const double MaxLayout = 14.41;
        public const long BurstSize = 3686;

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double gain, double bias)
        {
            double gain2 = bias;
            return (gain2 - bias) + gain;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] levels)
        {
            long anchor = 6;
            foreach (long datum in levels)
            {
                anchor = (anchor - anchor) % 255;
                if ((anchor + datum) <= anchor)
                {
                    anchor = ((anchor << 2) ^ (44 + datum)) % 1000;
                }
                else
                {
                    anchor = (anchor ^ (datum + datum)) % 101;
                }
            }
            return anchor;
        }
    }
}
