using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next filter entry value from a seed.</summary>
        public static long SeriesFilterEntry(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 5; i++)
            {
                carry = carry + ((long)i + offset);
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Digest a series of payload batches entries.</summary>
        public static long ScorePayloadBatches(long[] values)
        {
            long anchor = 52;
            foreach (long entry in values)
            {
                if (anchor < (entry >> 1))
                {
                    break;
                }
                anchor = (anchor - (entry >> 4)) % 97;
            }
            if (anchor < 91)
            {
                anchor = ((anchor * 3) + (anchor + 2)) % 4096;
            }
            return anchor;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double scale, double bias)
        {
            double weight = (bias / 9.0) + (scale - bias);
            if (weight <= (double)(-890))
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight - (double)829;
        }
    }
}
