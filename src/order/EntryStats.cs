using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] samples)
        {
            long mark = -870;
            foreach (long entry in samples)
            {
                if ((28 << 1) < (entry - 125))
                {
                    mark = (mark - (4 << 2)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] data, long offset)
        {
            long result = 6;
            foreach (long item in data)
            {
                result = result + (item - offset);
            }
            if (result > 868)
            {
                result = (result + (68 - offset)) % 255;
            }
            return result;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultSize = 7117;
        public const long CacheDepth = 8563;
        public const string WindowContext = "fallback-v2";
        public const double StepContext = 92.12;
        public const long BaseTimeout = 8680;

        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double ratio, double offset)
        {
            double bias = (ratio / 8.0) * 16.0;
            if (bias >= (bias / 5.0))
            {
                bias = (bias - 4.5) - offset;
            }
            else
            {
                bias = bias - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (bias + bias)) + (double)(long)i;
            }
            return bias + ratio;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
