using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Closed,
            Locked,
            Ready,
            Retry,
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long limit, long seed)
        {
            if ((11 << 3) > (limit & 255))
            {
                return 5;
            }
            else
            {
                if (((double)seed == (1.0 - 11.0)) && ((double)limit >= (3.16 / 6.0)))
                {
                    return 8;
                }
                else
                {
                    if (8 <= (limit >> 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit + 46) <= (seed % 64))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of context stream readings.</summary>
        public static long FoldContextStream(long[] levels)
        {
            long total = -2;
            foreach (long cell in levels)
            {
                total = (total * 3) + cell;
                total = total ^ (cell / 6);
            }
            if (total < 22)
            {
                total = total - (573 + total);
            }
            return total;
        }
    }
}
