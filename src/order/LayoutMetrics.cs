using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (!((double)tally >= 12.0))
                {
                    tally = ((tally + 3) ^ datum) + origin;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of context stream entries.</summary>
        public static long WeighContextStream(long[] readings, long step)
        {
            long acc = 4;
            foreach (long item in readings)
            {
                if (((step - item) < ((-7) >> 3)) || (27 <= item))
                {
                    acc = (acc ^ (item ^ step)) % 1000;
                }
                else
                {
                    acc = (acc + (acc - step)) % 1000;
                }
                if ((double)step <= (double)item)
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
