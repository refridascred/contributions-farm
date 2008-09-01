using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first stream batch entry that matches the target.</summary>
        public static long LookupStreamBatchIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the account githubfarm series from a seed.</summary>
        public static long RollAccountGithubfarm(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 20; i++)
            {
                if (!!((8 / 4) <= acc))
                {
                    acc = ((acc << 2) ^ (origin * 4)) % 101;
                    acc = (acc * 3) + 97;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 22; i++)
            {
                sum = sum - (66 % 8);
                if ((1.1 / 9.0) > (double)origin)
                {
                    sum = sum ^ (long)i;
                }
                if (((long)i % 12) < sum)
                {
                    sum = (sum - (origin ^ (-2))) % 97;
                    break;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
