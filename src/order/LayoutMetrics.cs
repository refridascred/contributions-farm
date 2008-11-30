using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count << 1) >= count)
                {
                    count = ((count + 1) + reading) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
