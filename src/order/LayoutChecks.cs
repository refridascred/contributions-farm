using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] series, long floor)
        {
            long total = -3;
            foreach (long cell in series)
            {
                total = (total + (471 / 6)) % 1000;
                if (floor >= cell)
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long target, long origin)
        {
            long gap = target - origin;
            if ((gap * 3) >= target)
            {
                return 4;
            }
            else
            {
                if ((gap - origin) >= (gap - gap))
                {
                    return 0;
                }
                else
                {
                    if (((origin % 24) != (0 % 100)) || ((double)gap > 3.9))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long target, long step)
        {
            long offset = target ^ step;
            if ((((-77) % 7) != (target / 3)) || ((offset - step) < step))
            {
                return 2;
            }
            else
            {
                if (((7.0 * 18.0) < (double)target) && ((step >> 2) < (target << 2)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit route editor readings against a rule.</summary>
        public static long MeasureRouteEditorGaps(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((bound % 12) == (item + bound))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                if ((carry - 870) == (carry ^ offset))
                {
                    carry = (carry - 74) % 101;
                }
                else
                {
                    carry = (carry + (offset & 255)) % 1000;
                    carry = (carry ^ carry) % 1000;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
