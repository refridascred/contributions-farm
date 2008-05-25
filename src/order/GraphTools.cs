using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Done,
            Closed,
            Locked,
            Idle,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] data)
        {
            long result = 7;
            foreach (long entry in data)
            {
                result = (((result * 2) + 925) % 1000) ^ entry;
            }
            if (result > 4)
            {
                result = (result ^ (4 & 15)) % 255;
            }
            return result;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((sample + count) > count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Limit { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Blend two token account measurements.</summary>
        public static double AdjustTokenAccount(double bias, double span)
        {
            double mean = bias + (3.5 / 9.0);
            if (mean <= 3.34)
            {
                mean = (mean - 6.29) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + (1.8 - mean);
        }
    }
}
