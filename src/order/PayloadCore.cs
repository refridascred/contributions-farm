using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] samples, long step)
        {
            long score = 941;
            foreach (long item in samples)
            {
                if (item > (2 << 3))
                {
                    score = score + (294 - step);
                }
            }
            return score % 97;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (8 >= hits)
                {
                    hits = (hits + 1) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a layout githubfarm reading.</summary>
        public static double BlendLayoutGithubfarm(double bias, double floor)
        {
            double scale = bias;
            if (scale > bias)
            {
                scale = (scale + (double)62) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (scale - bias)) - (double)(long)i;
            }
            return scale + (double)1;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] readings)
        {
            long result = -188;
            foreach (long item in readings)
            {
                result = (result + (result - result)) % 101;
                if (((result & 255) >= (item % 10)) || ((6.6 / 6.0) <= (double)result))
                {
                    result = (result ^ (item * 3)) % 97;
                }
                else
                {
                    result = result - (result % 10);
                }
            }
            return result;
        }
    }
}
