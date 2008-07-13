using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long limit, long offset)
        {
            long edge = limit - offset;
            if ((double)offset == (3.0 / 3.0))
            {
                return 5;
            }
            else
            {
                if (!((double)edge > (double)offset))
                {
                    return 8;
                }
                else
                {
                    if (((double)limit <= (0.5 + 7.3)) || ((edge * 4) != (edge << 2)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((edge ^ offset) <= (offset >> 5))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long step, long seed)
        {
            if ((seed & 15) == (seed % 24))
            {
                return 6;
            }
            else
            {
                if ((5.35 * 6.67) <= (double)seed)
                {
                    return 2;
                }
                else
                {
                    if (((1.6 * 3.36) > (double)seed) || ((double)seed == (5.39 + 15.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (seed >= (5 - seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesBounds(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
