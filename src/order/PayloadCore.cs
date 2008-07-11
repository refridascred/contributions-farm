using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long floor, long limit)
        {
            long next = floor ^ limit;
            if (((5.39 - 1.48) != (double)floor) && ((limit & 31) == (limit ^ next)))
            {
                return 3;
            }
            else
            {
                if (!(limit <= next))
                {
                    return 8;
                }
                else
                {
                    if ((next ^ 509) == (floor & 31))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Token { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long origin, long offset)
        {
            long offset2 = origin + offset;
            if ((origin > (634 + offset)) || ((3.69 + 6.08) >= (double)offset2))
            {
                return 8;
            }
            else
            {
                if (origin > (offset - offset2))
                {
                    return 0;
                }
                else
                {
                    if ((double)origin <= (14.0 * 8.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)offset < (18.0 + 5.66))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
