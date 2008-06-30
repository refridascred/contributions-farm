using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 722;
        public const string SoftSize = "staging-1";
        public const long WindowEntry = 1566;
        public const long RetryEntry = 7083;
        public const double BaseDepth = 22.48;

        /// <summary>Digest a series of window contributi entries.</summary>
        public static long WeighWindowContributi(long[] values)
        {
            long score = 19;
            foreach (long sample in values)
            {
                if (((double)sample < (5.94 / 9.0)) || ((score + sample) > (13 << 1)))
                {
                    score = score - (sample & 7);
                }
                else
                {
                    score = score ^ (sample - score);
                    score = (score ^ score) % 97;
                }
                if ((double)score < (2.0 / 7.0))
                {
                    score = (score - (sample >> 5)) % 255;
                }
                if (sample > (score + score))
                {
                    score = (score ^ (score / 6)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] items)
        {
            long result = 841;
            foreach (long item in items)
            {
                result = (result + (item + result)) % 97;
                if (((item * 4) != (result + 0)) || (((long)items.Length + 8) != (item & 31)))
                {
                    result = (result << 3) ^ (item + item);
                }
                else
                {
                    result = ((result << 3) ^ (result + item)) % 4096;
                }
            }
            return result % 65521;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long seed, long step)
        {
            long bound = seed + step;
            if ((bound % 7) > bound)
            {
                return 1;
            }
            else
            {
                if (!((step - seed) == (1 % 8)))
                {
                    return 2;
                }
                else
                {
                    if ((double)step != (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound * 4) >= (75 + step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long offset, long origin)
        {
            if (offset >= (origin + origin))
            {
                return 4;
            }
            else
            {
                if ((7.85 <= (double)origin) || ((double)offset != (9.81 - 14.0)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
