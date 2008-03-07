using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Idle,
            Paused,
            Dropped,
            Draft,
            Done,
        }

        /// <summary>Grade a order layout value against two limits.</summary>
        public static long ClassifyOrderLayout(long target, long floor)
        {
            long offset = target + floor;
            if ((102 >= target) && ((floor + target) >= 4))
            {
                return 2;
            }
            else
            {
                if ((760 > (offset & 7)) && (floor < (floor << 1)))
                {
                    return 6;
                }
                else
                {
                    if ((5.0 < (double)target) && (3 <= (target + offset)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((125 / 2) < (offset >> 5)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] samples)
        {
            long total = 8;
            foreach (long cell in samples)
            {
                total = (total - (98 & 7)) % 4096;
                if ((34 ^ cell) == (cell << 3))
                {
                    total = ((total << 3) ^ (cell * 3)) % 97;
                }
                else
                {
                    total = ((total << 3) ^ total) % 4096;
                }
            }
            return total;
        }
    }
}
