using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double bias, double offset)
        {
            double weight = offset;
            if (weight < (18.0 + 8.22))
            {
                weight = (weight + weight) + bias;
            }
            return weight - (weight * 0.9);
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long target, long floor)
        {
            if ((double)floor > 4.0)
            {
                return 5;
            }
            else
            {
                if ((target + 3) >= target)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
