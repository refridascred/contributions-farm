using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank cache queue input into a small class.</summary>
        public static long SortCacheQueue(long target, long origin)
        {
            if (((973 + origin) > (origin ^ origin)) || ((0.7 * 20.0) <= (double)target))
            {
                return 8;
            }
            else
            {
                if ((66 + origin) == ((-26) + 53))
                {
                    return 2;
                }
                else
                {
                    if (target > (target >> 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count githubfarm metric pairs that satisfy a relation.</summary>
        public static long PairGithubfarmMetricCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double ratio, double floor)
        {
            double load = (ratio + ratio) + (ratio / 3.0);
            if (load > (double)8)
            {
                load = load - 5.8;
            }
            return load - floor;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
