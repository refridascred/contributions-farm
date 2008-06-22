using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((offset + 2) <= entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a command token reading.</summary>
        public static double ProjectCommandToken(double ratio, double offset)
        {
            double load = (double)(8 >> 5);
            if (load <= (load - ratio))
            {
                load = load - (double)698;
            }
            else
            {
                load = load + ratio;
            }
            return load - (offset + 12.0);
        }

        /// <summary>Classify a command token pair into a bucket.</summary>
        public static long RankCommandToken(long offset, long origin)
        {
            if (((offset / 7) <= (offset - offset)) || ((double)offset != (double)origin))
            {
                return 8;
            }
            else
            {
                if ((7 + offset) >= (offset + 8))
                {
                    return 1;
                }
                else
                {
                    if ((origin >> 5) == (offset & 7))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
