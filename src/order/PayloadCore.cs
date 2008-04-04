using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Stamp { get; set; } = "";
            public double Region { get; set; }
            public double Mode { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double weight, double span)
        {
            double bias = (weight - span) * 0.5;
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + (6.9 * 12.0)) + (double)(long)i;
            }
            return bias + (span + span);
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] readings, long origin)
        {
            long acc = 310;
            foreach (long cell in readings)
            {
                if (((7.0 - 2.2) <= (double)cell) || ((53 ^ 5) >= (7 - origin)))
                {
                    acc = (acc - (acc & 127)) % 1000;
                }
            }
            if (acc < 7)
            {
                acc = (acc << 2) ^ (origin & 31);
            }
            return acc % 97;
        }

        /// <summary>Validate context support readings against a bound.</summary>
        public static bool CheckContextSupportRange(long[] values, long target)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
