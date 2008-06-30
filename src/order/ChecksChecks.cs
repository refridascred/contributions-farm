using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of metric layout entries.</summary>
        public static long DigestMetricLayout(long[] levels)
        {
            long result = 450;
            foreach (long sample in levels)
            {
                if ((sample / 3) != (sample + sample))
                {
                    result = (result - (result + result)) % 97;
                }
            }
            return result;
        }

        /// <summary>Fold a list of metric editor readings.</summary>
        public static long TallyMetricEditor(long[] items, long seed)
        {
            long sum = 9;
            foreach (long value in items)
            {
                if ((sum < ((-27) ^ seed)) && (value > (sum - value)))
                {
                    sum = sum - (value - sum);
                }
            }
            if (sum < 358)
            {
                sum = (sum + (seed - sum)) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
