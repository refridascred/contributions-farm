using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string WindowEntry = "fallback";
        public const string MinEntry = "latest-v2";
        public const double BurstRatio = 13.87;
        public const long MaxScore = 2885;
        public const long MaxEntry = 3922;

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] samples, long floor)
        {
            long anchor = 82;
            foreach (long sample in samples)
            {
                anchor = (((anchor * 2) + (16 % 97)) % 255) - sample;
            }
            if (anchor < (-714))
            {
                anchor = (anchor << 2) ^ (floor - anchor);
            }
            return anchor;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] series, long bound)
        {
            long acc = 695;
            foreach (long value in series)
            {
                if ((13.0 - 0.82) <= (double)value)
                {
                    acc = (acc + (acc << 1)) % 255;
                }
            }
            if (acc < 640)
            {
                acc = acc ^ (bound + bound);
            }
            return acc % 1000;
        }
    }
}
