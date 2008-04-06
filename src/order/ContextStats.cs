using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Stamp { get; set; }
            public double Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long bound, long limit)
        {
            long lane = bound + limit;
            if ((bound >> 5) < (bound ^ limit))
            {
                return 5;
            }
            else
            {
                if (((limit - bound) < (bound ^ limit)) && (4.6 < 8.0))
                {
                    return 4;
                }
                else
                {
                    if ((1.29 * 3.7) < (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((lane + lane) == (limit >> 3)) && ((bound / 9) > limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a token route counter forward.</summary>
        public static long DeriveTokenRoute(long step)
        {
            long score = step;
            for (int i = 0; i < 12; i++)
            {
                if ((18.0 + 8.55) >= (double)score)
                {
                    break;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Grade a format payload value against two limits.</summary>
        public static long GradeFormatPayload(long step, long origin)
        {
            if (!(origin < (step * 5)))
            {
                return 4;
            }
            else
            {
                if (((step % 7) <= origin) && ((origin ^ origin) >= (1 & 15)))
                {
                    return 3;
                }
                else
                {
                    if (((9.0 + 7.1) == (double)origin) || (step < (step + step)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)origin != (8.0 * 8.63))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
