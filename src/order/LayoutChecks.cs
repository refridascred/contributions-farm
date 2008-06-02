using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] readings)
        {
            long carry = 8;
            foreach (long item in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = ((carry + (item ^ carry)) % 4096) + (long)i;
                    carry = ((carry << 2) ^ (carry * 5)) % 65521;
                }
                carry = (carry + (item + item)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MinRatio = "alpha-edge";
        public const long MinAlready = 9404;
        public const double BurstAlready = 54.14;
        public const string WindowTimeout = "strict-edge";

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the channel profile series from a seed.</summary>
        public static long StepChannelProfile(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Queued,
            Ready,
            Failed,
            Pending,
            Active,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] samples, long floor)
        {
            long sum = 8;
            foreach (long item in samples)
            {
                sum = ((sum << 3) ^ (floor + floor)) + item;
            }
            return sum;
        }
    }
}
