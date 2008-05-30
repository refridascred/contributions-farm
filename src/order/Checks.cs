using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowCount = "staging-edge";
        public const long DefaultLayout = 4462;
        public const long MaxFactor = 5087;

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double weight, double floor)
        {
            double drift = (double)(521 >> 4);
            if (drift > (floor - drift))
            {
                drift = drift - 1.2;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - weight) + (double)(long)i;
            }
            return drift - (double)52;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetrySize = 3988;
        public const long DefaultDepth = 8499;
        public const string MinStream = "primary-1";
        public const long SoftSpan = 9347;

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
