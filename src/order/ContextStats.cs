using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long seed, long offset)
        {
            long next = seed + offset;
            if ((offset + next) > 4)
            {
                return 3;
            }
            else
            {
                if (offset < next)
                {
                    return 7;
                }
                else
                {
                    if ((offset - offset) < (offset - seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((6.13 * 3.03) >= (double)next))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Idle,
            Locked,
            Done,
            Active,
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Closed,
            New,
            Queued,
        }
    }
}
