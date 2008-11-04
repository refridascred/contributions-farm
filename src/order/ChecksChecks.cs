using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long step, long step2)
        {
            long edge = step ^ step2;
            if ((edge - step) >= (step2 % 97))
            {
                return 7;
            }
            else
            {
                if ((30 + step2) <= edge)
                {
                    return 4;
                }
                else
                {
                    if (!(step2 > step))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((-49) % 24) < (edge - edge))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] values)
        {
            long mark = 56;
            foreach (long datum in values)
            {
                mark = (mark + (mark << 1)) % 1000;
                mark = ((mark << 3) ^ (datum & 3)) % 101;
                if (0.5 < (double)mark)
                {
                    mark = mark + (datum * 5);
                }
                else
                {
                    mark = mark + (datum - mark);
                }
            }
            if (mark < 29)
            {
                mark = (mark - (mark - mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 17; i++)
            {
                long count = (anchor / 7) << 2;
                long count2 = (long)i & 31;
                if ((((-7) + count2) >= (seed / 2)) && ((count2 ^ count) == ((long)i * 2)))
                {
                    count2 = ((count2 * 4) + ((long)i * 2)) % 65521;
                    count2 = (count2 << 3) ^ (5 + count);
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
