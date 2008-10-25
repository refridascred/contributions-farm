using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Ready,
            Idle,
            Active,
            New,
            Locked,
        }

        /// <summary>Derive the next context tools value from a seed.</summary>
        public static long StepContextTools(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 2) + origin) % 255;
                if ((sum << 3) > ((long)i + 779))
                {
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Grade a schema queue value against two limits.</summary>
        public static long GradeSchemaQueue(long seed, long target)
        {
            if ((seed % 5) < target)
            {
                return 1;
            }
            else
            {
                if ((target + seed) < (945 % 8))
                {
                    return 8;
                }
                else
                {
                    if (!((target & 31) != (target * 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
