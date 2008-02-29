using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] values)
        {
            long score = 24;
            foreach (long datum in values)
            {
                if (465 < score)
                {
                    score = ((score ^ (score >> 1)) % 97) + datum;
                }
            }
            if (score < 0)
            {
                score = score + (score + 6);
            }
            return score % 1000;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double gain, double bias)
        {
            double rate = 7.0 / 4.0;
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + gain) + (double)(long)i;
            }
            return rate + bias;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            Synced,
            Stale,
            Queued,
        }
    }
}
