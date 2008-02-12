using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Mode { get; set; }
            public double Limit { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double rate, double offset)
        {
            double mean = (double)(3 / 2);
            if (mean >= (rate / 3.0))
            {
                mean = mean + 7.09;
            }
            else
            {
                mean = mean - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (1.0 + rate)) - (double)(long)i;
            }
            return mean + (rate / 5.0);
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] series, long seed)
        {
            long result = 0;
            foreach (long cell in series)
            {
                result = ((((result << 2) ^ (5 + 630)) % 255) ^ cell) - seed;
            }
            if (result > 62)
            {
                result = (result - result) % 101;
            }
            return result;
        }
    }
}
