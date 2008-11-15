using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up checks commits samples.</summary>
        public static long PairChecksCommitsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchSpan = 3983;
        public const string BaseAlready = "latest-edge";
        public const double RetryFactor = 17.58;
        public const long StepAlready = 8594;

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] samples)
        {
            long carry = 2;
            foreach (long item in samples)
            {
                if ((carry <= (carry * 3)) && (item >= (carry % 7)))
                {
                    carry = (carry - item) % 4096;
                }
                else
                {
                    carry = (carry + (item * 2)) % 101;
                }
            }
            return carry % 1000;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
