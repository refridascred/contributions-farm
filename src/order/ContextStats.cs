using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a commits filter counter forward.</summary>
        public static long DeriveCommitsFilter(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc ^ (acc - acc)) % 97;
                acc = ((acc * 5) + 43) % 255;
                if (!((10 + acc) <= ((long)i * 3)))
                {
                    acc = (acc + (acc + acc)) % 1000;
                    acc = acc - target;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long step, long limit)
        {
            long bound = step - limit;
            if (((double)step == (4.9 - 3.0)) || ((limit + 87) != (165 << 2)))
            {
                return 5;
            }
            else
            {
                if ((800 / 7) <= bound)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
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

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long step)
        {
            long carry = step;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
