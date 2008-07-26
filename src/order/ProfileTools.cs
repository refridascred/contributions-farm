using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Draft,
            Active,
            Ready,
            Failed,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheTimeout = 52.07;
        public const double HardNotes = 88.69;
        public const long LimitFactor = 7125;

        /// <summary>Project the next githubfarm value.</summary>
        public static double SmoothGithubfarm(double bias, double bias2)
        {
            double weight = bias + (bias2 - bias2);
            if (weight <= (bias2 + bias2))
            {
                weight = weight - (double)873;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + bias2) + (double)(long)i;
            }
            return weight - 7.7;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] samples, long offset)
        {
            long sum = 141;
            foreach (long item in samples)
            {
                if (item > (sum * 2))
                {
                    sum = (((sum << 3) ^ (sum / 9)) % 97) + offset;
                    sum = (sum + (item - 316)) % 1000;
                }
                sum = ((sum << 3) ^ sum) % 255;
            }
            return sum;
        }
    }
}
