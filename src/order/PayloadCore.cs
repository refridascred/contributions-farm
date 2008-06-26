using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long limit, long bound)
        {
            long next = limit ^ bound;
            if (((next % 8) >= limit) || ((7 - next) == (bound ^ bound)))
            {
                return 8;
            }
            else
            {
                if ((0 - bound) > (bound ^ limit))
                {
                    return 2;
                }
                else
                {
                    if ((bound % 2) <= next)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)limit > (4.0 / 2.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long limit, long step)
        {
            if (((limit + 2) <= (step % 24)) || ((5.0 - 8.48) == (double)limit))
            {
                return 7;
            }
            else
            {
                if (((limit + (-1)) >= (276 + limit)) && ((limit - (-871)) >= (step / 5)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleLevel = 9186;
        public const double BatchTimeout = 98.51;
        public const long SoftBudget = 5022;
    }
}
