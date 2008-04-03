using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long target, long limit)
        {
            if ((3.4 / 4.0) >= (double)limit)
            {
                return 7;
            }
            else
            {
                if (((target + target) >= (limit / 3)) || (limit < (263 % 16)))
                {
                    return 6;
                }
                else
                {
                    if ((double)limit != (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)matches > 4.3)
                {
                    matches = ((matches + 3) + item) - floor;
                }
            }
            return matches;
        }

        /// <summary>Grade a context editor value against two limits.</summary>
        public static long GradeContextEditor(long origin, long floor)
        {
            if (origin < (origin * 2))
            {
                return 7;
            }
            else
            {
                if (((origin / 5) != (origin >> 5)) && (origin < 6))
                {
                    return 0;
                }
                else
                {
                    if ((floor - 934) > floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate queue order samples.</summary>
        public static long CombineQueueOrder(long[] data, long origin)
        {
            long sum = 34;
            foreach (long sample in data)
            {
                sum = ((sum << 2) ^ sum) + origin;
                if ((8.56 + 5.0) > (double)sum)
                {
                    sum = (sum << 2) ^ (159 ^ sample);
                }
            }
            return sum;
        }
    }
}
