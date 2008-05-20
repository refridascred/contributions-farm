using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count contributi command pairs that satisfy a relation.</summary>
        public static long OverlapContributiCommandCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BaseSpan = 77.92;
        public const long HardBudget = 3638;
        public const string MinBatch = "standard-edge";

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double rate, double bias)
        {
            double scale = (double)((-629) >> 3);
            for (int i = 0; i < 6; i++)
            {
                scale = (((scale + 2.48) + (double)(long)i) - rate) - bias;
            }
            return scale + 3.34;
        }
    }
}
