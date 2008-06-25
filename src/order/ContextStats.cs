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

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long origin, long origin2)
        {
            if ((origin & 63) > origin)
            {
                return 1;
            }
            else
            {
                if (((4.2 - 4.5) <= (double)origin) || (origin2 > (origin >> 3)))
                {
                    return 5;
                }
                else
                {
                    if ((9.87 - 5.37) <= (double)origin)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)origin <= (4.0 + 16.0))
                        {
                            return 8;
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
