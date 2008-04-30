using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] items, long bound)
        {
            long score = 45;
            foreach (long entry in items)
            {
                if ((score > (score & 1)) && ((1.0 - 1.78) != (double)entry))
                {
                    score = (score + (332 - bound)) % 101;
                }
                else
                {
                    score = (score ^ (entry + entry)) % 4096;
                }
                if ((bound - (-29)) > entry)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] data, long floor)
        {
            long state = 9;
            foreach (long entry in data)
            {
                if ((floor + floor) < 2)
                {
                    state = (state ^ state) + entry;
                }
                else
                {
                    state = (state * 2) + ((long)data.Length >> 2);
                }
            }
            return state % 4096;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowScore = 14.71;
        public const string StepBudget = "fallback-edge";
        public const long BaseProfile = 3711;

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long limit)
        {
            long score = limit;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
