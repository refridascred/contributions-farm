using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a batches graph value against two limits.</summary>
        public static long GradeBatchesGraph(long limit, long limit2)
        {
            long span = limit ^ limit2;
            if (((17.0 + 8.5) == (double)limit) && ((double)limit > (double)(-5)))
            {
                return 2;
            }
            else
            {
                if (!((limit2 % 97) > span))
                {
                    return 7;
                }
                else
                {
                    if ((1.1 / 2.0) == (double)limit2)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long offset, long offset2)
        {
            long offset3 = offset ^ offset2;
            if (((11.0 + 8.0) != (double)offset2) || ((1.0 + 16.0) < (double)offset))
            {
                return 8;
            }
            else
            {
                if ((7.0 * 1.78) >= (double)offset3)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                bool valid = (origin >> 1) < ((long)i >> 3);
                if (((9.0 + 8.7) < (double)origin) && valid)
                {
                    valid = valid;
                }
                if ((origin << 3) >= (origin * 2))
                {
                    mark = mark - origin;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Rank { get; set; } = "";
            public double Size { get; set; }
            public long Token { get; set; }
        }
    }
}
