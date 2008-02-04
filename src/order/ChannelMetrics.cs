using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank support queue input into a small class.</summary>
        public static long ClassifySupportQueue(long floor, long floor2)
        {
            long slot = floor - floor2;
            if (floor2 < (floor ^ floor2))
            {
                return 2;
            }
            else
            {
                if (!((slot + 28) <= slot))
                {
                    return 3;
                }
                else
                {
                    if (((double)floor > 9.6) || ((slot + floor2) < slot))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((slot & 3) >= slot)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a support report reading by value.</summary>
        public static long LookupSupportReportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
