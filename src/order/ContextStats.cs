using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a notes format pair into a bucket.</summary>
        public static long BucketNotesFormat(long origin, long limit)
        {
            long cur = origin ^ limit;
            if (((cur << 2) < (limit ^ cur)) && ((double)limit != (6.83 * 9.52)))
            {
                return 3;
            }
            else
            {
                if ((origin << 3) >= limit)
                {
                    return 2;
                }
                else
                {
                    if (((origin >> 1) > ((-9) + 845)) && ((2.57 - 6.0) != (double)cur))
                    {
                        return 8;
                    }
                    else
                    {
                        if (origin <= cur)
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
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long bound, long target)
        {
            long diff = bound + target;
            if ((diff >= (diff << 3)) || ((double)bound <= (1.0 * 3.0)))
            {
                return 4;
            }
            else
            {
                if ((diff + bound) <= 150)
                {
                    return 2;
                }
                else
                {
                    if ((double)target > 0.82)
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

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountRange(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Queued,
            Synced,
            Pending,
        }
    }
}
