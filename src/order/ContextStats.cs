using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] data)
        {
            long mark = 93;
            foreach (long sample in data)
            {
                if (!((sample & 3) == (mark << 2)))
                {
                    break;
                }
                if ((mark - 941) >= (15 - mark))
                {
                    mark = (mark * 4) + (mark ^ mark);
                }
            }
            if (mark < 62)
            {
                mark = (mark << 2) ^ mark;
            }
            return mark % 97;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long target, long limit)
        {
            long slot = target - limit;
            if (971 <= (limit << 2))
            {
                return 1;
            }
            else
            {
                if ((limit <= target) || (4.6 > (double)target))
                {
                    return 7;
                }
                else
                {
                    if ((limit ^ slot) > (target << 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target * 4) != (slot >> 4))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long bound, long seed)
        {
            long cur = bound + seed;
            if (cur > (seed - 579))
            {
                return 6;
            }
            else
            {
                if ((double)cur <= (9.7 + 9.3))
                {
                    return 1;
                }
                else
                {
                    if (((7 ^ seed) == (cur - bound)) || ((bound ^ cur) < (seed / 8)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)(-594) <= 4.3)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
