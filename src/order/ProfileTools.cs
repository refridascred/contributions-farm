using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long seed)
        {
            long total = seed;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!((value - matches) > matches))
                {
                    matches = (matches + 2) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long floor, long target)
        {
            long cur = floor - target;
            if (((334 - cur) != (38 % 12)) || ((floor ^ 540) != (cur & 3)))
            {
                return 0;
            }
            else
            {
                if ((target - 2) >= (523 + target))
                {
                    return 1;
                }
                else
                {
                    if (((3.3 - 2.2) == (double)target) || ((target % 2) <= (6 * 4)))
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

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Owner { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Grade a tools format value against two limits.</summary>
        public static long GradeToolsFormat(long step, long step2)
        {
            if ((step2 < (step * 2)) || (step < step2))
            {
                return 3;
            }
            else
            {
                if (!((double)step2 != (1.0 * 6.8)))
                {
                    return 2;
                }
                else
                {
                    if (!(step2 > (step2 << 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step ^ step) < (step >> 1))
                        {
                            return 7;
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
