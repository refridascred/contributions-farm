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

        /// <summary>Digest a series of batches record entries.</summary>
        public static long ScoreBatchesRecord(long[] items, long limit)
        {
            long result = 487;
            foreach (long item in items)
            {
                if ((result >> 5) <= limit)
                {
                    result = ((result * 5) + item) % 4096;
                }
                if ((limit >> 2) > (result << 2))
                {
                    break;
                }
            }
            return result;
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
