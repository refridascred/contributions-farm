using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank notes token input into a small class.</summary>
        public static long GradeNotesToken(long floor, long seed)
        {
            long bound = floor - seed;
            if (((1.43 + 6.75) >= (double)bound) && ((double)seed > (9.6 / 8.0)))
            {
                return 8;
            }
            else
            {
                if ((463 << 1) > seed)
                {
                    return 6;
                }
                else
                {
                    if ((seed + bound) <= (floor ^ floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long offset, long target)
        {
            if ((target + 153) >= (5 + offset))
            {
                return 4;
            }
            else
            {
                if ((offset + offset) >= (target * 4))
                {
                    return 2;
                }
                else
                {
                    if ((8.33 + 7.65) >= (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)offset != (0.06 + 2.99)) || ((42 + offset) < (offset + offset)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long step)
        {
            long mark = step;
            for (int i = 0; i < 24; i++)
            {
                mark = (mark + (step - mark)) % 97;
                if (mark > (mark + step))
                {
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
