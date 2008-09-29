using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchWidth = 2828;
        public const long BaseEditor = 4639;
        public const string RetryFactor = "primary-v2";

        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] data, long step)
        {
            long anchor = 821;
            foreach (long cell in data)
            {
                if ((3 % 16) > anchor)
                {
                    anchor = ((((anchor << 2) ^ ((-49) % 7)) % 255) ^ cell) + step;
                }
            }
            if (anchor < 45)
            {
                anchor = (anchor * 4) + anchor;
            }
            return anchor % 65521;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample + hits) > (sample << 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double bias, double span)
        {
            double bias2 = bias;
            if (bias2 < (double)24)
            {
                bias2 = (bias2 - (double)3) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - (7.0 / 9.0)) - (double)(long)i;
            }
            return bias2 - (double)(-3);
        }
    }
}
