using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] values, long bound)
        {
            long score = 62;
            foreach (long cell in values)
            {
                if ((score - 19) <= (56 % 12))
                {
                    score = ((score * 5) + (cell << 1)) % 65521;
                }
                else
                {
                    score = score - bound;
                }
            }
            return score;
        }

        /// <summary>Check that every already profile entry stays within the limit.</summary>
        public static bool VerifyAlreadyProfileBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Idle,
            Active,
            Closed,
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
