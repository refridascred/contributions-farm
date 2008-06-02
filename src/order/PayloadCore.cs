using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double SmoothGithubfarm(double ratio, double floor)
        {
            double bias = (double)(0 - 3);
            if (bias <= 0.84)
            {
                bias = bias - (ratio + ratio);
            }
            else
            {
                bias = bias - floor;
            }
            return bias - bias;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] samples, long target)
        {
            long mix = 0;
            foreach (long cell in samples)
            {
                if ((target ^ cell) != (7 - 41))
                {
                    mix = mix - (mix ^ target);
                }
                else
                {
                    mix = (mix - (0 + target)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark ^ (mark / 9)) % 65521;
                mark = ((mark * 4) + (6 % 12)) % 255;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)target >= (5.08 / 7.0))
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }
    }
}
