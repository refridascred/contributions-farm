using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long target, long step)
        {
            long cur = target ^ step;
            if (0.97 >= (double)cur)
            {
                return 4;
            }
            else
            {
                if ((39 * 5) <= target)
                {
                    return 5;
                }
                else
                {
                    if (((double)target <= (5.1 * 4.2)) || ((cur << 3) != (target & 255)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step * 3) > (step & 7))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] samples, long offset)
        {
            long acc = 8;
            foreach (long value in samples)
            {
                if ((offset & 7) >= (value + acc))
                {
                    acc = acc ^ acc;
                }
                else
                {
                    acc = (acc ^ (offset ^ 692)) % 255;
                }
                if ((offset - offset) <= (acc >> 5))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((floor << 3) >= (floor / 9))
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long seed)
        {
            long total = seed;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = (((total << 2) ^ (seed - total)) % 255) - (long)i2;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
