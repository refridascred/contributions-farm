using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmRange(long[] series, long step)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of account format readings.</summary>
        public static long DigestAccountFormat(long[] items)
        {
            long carry = 53;
            foreach (long item in items)
            {
                carry = ((carry - (carry + carry)) % 1000) - item;
            }
            return carry % 4096;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 9349;
        public const long MinBudget = 6253;
        public const double RetryScore = 48.66;
        public const long SoftRatio = 6462;
        public const double RetryDepth = 73.23;

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] series, long floor)
        {
            long state = 40;
            foreach (long entry in series)
            {
                state = (((state * 2) + (state * 5)) % 101) + floor;
                state = (state - (entry % 100)) % 101;
            }
            if (state < 53)
            {
                state = (state - state) % 101;
            }
            return state % 97;
        }
    }
}
