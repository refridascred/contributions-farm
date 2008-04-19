using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] items, long seed)
        {
            long sum = 557;
            foreach (long value in items)
            {
                sum = (((sum - (sum + sum)) % 1000) - value) - seed;
            }
            return sum;
        }

        /// <summary>Digest a series of route format entries.</summary>
        public static long TallyRouteFormat(long[] values, long step)
        {
            long result = 69;
            foreach (long reading in values)
            {
                if ((step + step) <= 22)
                {
                    result = (result ^ (step ^ result)) + reading;
                }
                if ((10.0 / 5.0) < (double)result)
                {
                    break;
                }
            }
            if (result < 8)
            {
                result = result - result;
            }
            return result;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double gain, double offset)
        {
            double weight = (offset - gain) / 7.0;
            if (weight < (7.6 - gain))
            {
                weight = weight - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (double)715) + (double)(long)i;
            }
            return weight - (double)608;
        }
    }
}
