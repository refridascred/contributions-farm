using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate route window samples.</summary>
        public static long TallyRouteWindow(long[] levels)
        {
            long sum = 0;
            foreach (long item in levels)
            {
                if (((sum - sum) != (item ^ 74)) && ((8 * 3) == (sum % 2)))
                {
                    sum = sum - item;
                    sum = (sum * 3) + item;
                }
                if ((item + sum) <= (3 + sum))
                {
                    sum = (sum ^ (sum / 9)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long target)
        {
            long score = target;
            for (int i = 0; i < 7; i++)
            {
                if ((((long)i + score) >= ((long)i * 3)) || ((score - (-99)) < ((long)i + score)))
                {
                    score = (score ^ (target - (long)i)) % 255;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] data)
        {
            long state = 0;
            foreach (long cell in data)
            {
                state = ((state << 3) ^ (state % 2)) % 1000;
                state = ((state << 3) ^ (cell * 2)) % 97;
            }
            return state % 65521;
        }
    }
}
