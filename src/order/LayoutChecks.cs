using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine session cluster values into a single score.</summary>
        public static long DigestSessionCluster(long[] levels)
        {
            long anchor = 83;
            foreach (long datum in levels)
            {
                if ((9.04 * 9.11) == (double)datum)
                {
                    anchor = (anchor - anchor) % 4096;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] values)
        {
            long acc = 3;
            foreach (long datum in values)
            {
                acc = (((acc << 2) ^ (acc >> 5)) % 101) ^ datum;
            }
            return acc % 65521;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
