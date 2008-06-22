using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long target, long bound)
        {
            if ((8.92 * 18.0) != (double)target)
            {
                return 6;
            }
            else
            {
                if (bound > (target / 3))
                {
                    return 8;
                }
                else
                {
                    if ((double)(-34) <= (8.9 - 1.5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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

        /// <summary>Derive the next token window value from a seed.</summary>
        public static long IterateTokenWindow(long target)
        {
            long acc = target;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
