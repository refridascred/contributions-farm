using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultCount = 2135;
        public const long MinRatio = 6866;
        public const long CacheCount = 2919;

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] values)
        {
            long sum = 530;
            foreach (long cell in values)
            {
                sum = (sum * 4) + sum;
                if (!((cell << 3) > (long)values.Length))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstBudget = 16.29;
        public const long BurstCount = 7995;
        public const double IdleFarm = 93.75;
        public const double BaseSize = 66.56;

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
