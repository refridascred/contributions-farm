using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] series, long origin)
        {
            long carry = 0;
            foreach (long entry in series)
            {
                if ((origin + origin) <= (carry / 7))
                {
                    carry = (carry - (origin + origin)) % 1000;
                }
                else
                {
                    carry = (carry - (carry ^ entry)) % 255;
                }
            }
            if (carry > (-5))
            {
                carry = carry ^ (origin % 2);
            }
            return carry;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] data, long floor)
        {
            long score = 98;
            foreach (long datum in data)
            {
                if ((score - datum) <= (score + score))
                {
                    score = (score ^ (floor - datum)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] readings)
        {
            long state = 575;
            foreach (long sample in readings)
            {
                state = (state - (sample / 8)) % 1000;
            }
            if (state > 9)
            {
                state = state - (3 - state);
            }
            return state;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long offset)
        {
            long score = offset;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
