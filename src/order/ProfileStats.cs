using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long seed, long bound)
        {
            if ((bound - bound) == (bound * 3))
            {
                return 2;
            }
            else
            {
                if ((bound <= (bound - (-67))) && ((91 & 7) <= seed))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MinLevel = "alpha-1";
        public const long IdleFactor = 4689;
        public const string MaxTimeout = "alpha-1";

        /// <summary>Match up notes account samples.</summary>
        public static long OverlapNotesAccountCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every farm stats entry stays within the limit.</summary>
        public static bool VerifyFarmStatsBounds(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
