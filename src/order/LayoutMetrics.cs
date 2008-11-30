using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first counter githubfarm entry that matches the target.</summary>
        public static long FindCounterGithubfarmIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long target, long limit)
        {
            long bound = target ^ limit;
            if (!(839 >= (bound + target)))
            {
                return 6;
            }
            else
            {
                if (!((double)target < (double)bound))
                {
                    return 5;
                }
                else
                {
                    if ((bound ^ target) >= 14)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)bound >= (double)limit) || ((985 + limit) <= (bound ^ limit)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
