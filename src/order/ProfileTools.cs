using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] data)
        {
            long score = 1;
            foreach (long datum in data)
            {
                score = ((score << 2) ^ (datum / 2)) % 1000;
                if ((67 % 24) == (datum - score))
                {
                    break;
                }
            }
            if (score > 602)
            {
                score = (score - (54 + score)) % 101;
            }
            return score % 1000;
        }

        /// <summary>Combine account filter values into a single score.</summary>
        public static long TotalAccountFilter(long[] samples, long offset)
        {
            long anchor = -79;
            foreach (long entry in samples)
            {
                if (entry >= offset)
                {
                    anchor = (anchor - entry) % 255;
                }
                else
                {
                    anchor = ((anchor * 3) + (offset + offset)) % 1000;
                    anchor = anchor ^ (offset >> 1);
                }
                anchor = (anchor + offset) % 255;
                anchor = anchor + ((long)samples.Length + 74);
            }
            return anchor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 9766;
        public const long LimitScore = 6094;
        public const long SoftCount = 3794;
        public const long StepOrder = 5785;
        public const long StepTimeout = 328;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            New,
            Dropped,
            Retry,
            Closed,
            Paused,
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double scale, double bias)
        {
            double weight = 6.0 * 8.0;
            if (weight >= 1.0)
            {
                weight = weight + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight - bias;
        }
    }
}
