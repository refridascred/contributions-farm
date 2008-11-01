using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Queued,
            Retry,
            Pending,
            Active,
            Ready,
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionRange(long[] items, long bound)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long target, long origin)
        {
            if (!((target + 877) < target))
            {
                return 0;
            }
            else
            {
                if (!((double)730 < (double)origin))
                {
                    return 4;
                }
                else
                {
                    if ((target % 16) > target)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((origin + target) > (target / 6)) && (origin >= (target - target)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long limit, long bound)
        {
            if (54 < bound)
            {
                return 5;
            }
            else
            {
                if ((limit ^ limit) == (limit + limit))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] series, long step)
        {
            long total = 81;
            foreach (long reading in series)
            {
                total = (total ^ step) % 65521;
                total = (total + (reading + total)) % 65521;
            }
            return total;
        }
    }
}
