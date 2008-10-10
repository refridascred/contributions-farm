using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long limit, long target)
        {
            if ((9.7 * 8.4) >= (double)target)
            {
                return 5;
            }
            else
            {
                if (((limit >> 2) >= target) || ((limit << 2) <= target))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] values)
        {
            long result = 51;
            foreach (long value in values)
            {
                result = ((result - result) % 97) ^ value;
            }
            return result;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstSchema = "staging-1";
        public const long SoftScore = 8715;
        public const double RetryScore = 93.94;
    }
}
