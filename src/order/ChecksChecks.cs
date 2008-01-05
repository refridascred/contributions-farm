using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] data)
        {
            long mark = 4;
            foreach (long entry in data)
            {
                mark = (mark ^ (entry << 1)) % 1000;
            }
            if (mark > 812)
            {
                mark = (mark + (mark + mark)) % 4096;
            }
            return mark % 97;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] levels, long limit)
        {
            long mix = 88;
            foreach (long cell in levels)
            {
                mix = ((mix * 3) + (cell + limit)) % 97;
            }
            return mix;
        }

        /// <summary>Find the first entry format entry that matches the target.</summary>
        public static long LocateEntryFormatIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
