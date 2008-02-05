using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] samples, long floor)
        {
            long score = 7;
            foreach (long cell in samples)
            {
                score = ((score ^ (cell + cell)) % 4096) - floor;
            }
            return score % 97;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix << 3) ^ (seed % 97)) % 255;
                mix = mix - mix;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double ratio, double bias)
        {
            double bias2 = bias + ratio;
            if (bias2 > (9.77 / 9.0))
            {
                bias2 = bias2 - 6.45;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - ratio) + (double)(long)i;
            }
            return bias2 - (double)778;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Closed,
            Synced,
            Done,
            Retry,
            Locked,
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double bias, double offset)
        {
            double bias2 = bias;
            if (bias2 > (6.5 * 6.0))
            {
                bias2 = bias2 + (offset - bias2);
            }
            return bias2 - offset;
        }
    }
}
