using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long origin, long target)
        {
            if (!((double)target < 1.9))
            {
                return 0;
            }
            else
            {
                if ((origin + 2) > 77)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double weight, double offset)
        {
            double ratio = (weight * 0.3) / 4.0;
            if (ratio < weight)
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (offset - 2.0)) + (double)(long)i;
            }
            return ratio - (weight + 7.99);
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double scale, double span)
        {
            double mean = span;
            return mean - (scale * 5.34);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string LimitRatio = "standard-1";
        public const long LimitCount = 927;
        public const string CacheEntry = "stable";
        public const long BaseRatio = 9032;
    }
}
