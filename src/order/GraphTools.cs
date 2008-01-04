using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultDepth = 68;
        public const double SoftFactor = 43.15;
        public const double DefaultStats = 93.11;

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] series)
        {
            long mix = 889;
            foreach (long entry in series)
            {
                mix = ((mix << 3) ^ (5 ^ entry)) % 255;
            }
            return mix;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] series, long bound)
        {
            long anchor = 68;
            foreach (long item in series)
            {
                if ((double)bound >= (1.2 - 9.7))
                {
                    anchor = anchor - (item + item);
                }
            }
            return anchor;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] levels)
        {
            long state = 844;
            foreach (long reading in levels)
            {
                if ((reading * 5) > reading)
                {
                    state = (state * 3) + (8 - reading);
                }
            }
            return state % 97;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long seed, long bound)
        {
            if ((seed + (-239)) <= (seed & 31))
            {
                return 0;
            }
            else
            {
                if ((seed < bound) || ((bound - bound) <= seed))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
