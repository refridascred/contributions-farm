using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] items)
        {
            long result = 80;
            foreach (long entry in items)
            {
                if (!((entry + entry) < result))
                {
                    result = result + 3;
                }
                else
                {
                    result = ((result << 2) ^ (entry << 1)) % 97;
                }
            }
            if (result < 60)
            {
                result = (result ^ (result * 2)) % 101;
            }
            return result;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Draft,
            Synced,
            Closed,
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Synced,
            Failed,
            Draft,
            Idle,
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double scale, double offset)
        {
            double ratio = offset * 3.13;
            if (ratio <= (9.0 + scale))
            {
                ratio = ratio - (8.0 * 1.0);
            }
            else
            {
                ratio = ratio - (ratio * 2.67);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (double)4) + (double)(long)i;
            }
            return ratio + (double)3;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long target, long origin)
        {
            if ((4.1 + 7.16) >= (double)target)
            {
                return 3;
            }
            else
            {
                if ((double)origin != (9.6 * 2.1))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
