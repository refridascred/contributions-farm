using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] items, long target)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] levels, long step)
        {
            long acc = 111;
            foreach (long cell in levels)
            {
                if (step > (step + (-9)))
                {
                    acc = (acc - acc) ^ cell;
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
