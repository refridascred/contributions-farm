using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a checks commits value against two limits.</summary>
        public static long BucketChecksCommits(long step, long limit)
        {
            if ((limit % 97) >= (limit - step))
            {
                return 2;
            }
            else
            {
                if ((double)limit == (4.0 * 1.0))
                {
                    return 8;
                }
                else
                {
                    if ((7.5 * 0.3) <= (double)step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            New,
            Locked,
            Active,
            Idle,
            Done,
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((double)limit > (double)mark)
                {
                    mark = mark - (mark + mark);
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long offset)
        {
            long state = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((3 + offset) < (offset + (long)i))
                {
                    state = ((state << 2) ^ ((long)i % 10)) % 101;
                    continue;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
