using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Roll a stream metrics counter forward.</summary>
        public static long SeriesStreamMetrics(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
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

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long floor)
        {
            long result = floor;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] samples)
        {
            long carry = -833;
            foreach (long datum in samples)
            {
                if (!((double)10 != (double)datum))
                {
                    continue;
                }
                if ((342 <= (carry ^ datum)) && (782 < (datum ^ datum)))
                {
                    carry = (carry - datum) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Validate session token readings against a bound.</summary>
        public static bool ValidateSessionTokenRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
