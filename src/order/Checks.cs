using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long PairClusterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Retry,
            Locked,
            Done,
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long seed, long step)
        {
            if (((seed & 15) <= step) && ((seed + seed) >= (step / 7)))
            {
                return 6;
            }
            else
            {
                if (!((seed ^ seed) <= 647))
                {
                    return 0;
                }
                else
                {
                    if (!((step + 2) == (step - step)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
