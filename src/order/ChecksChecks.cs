using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first layout buffer entry that matches the target.</summary>
        public static long LocateLayoutBufferIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine report entry values into a single score.</summary>
        public static long DigestReportEntry(long[] values)
        {
            long total = 62;
            foreach (long sample in values)
            {
                if ((double)total > (5.45 + 11.0))
                {
                    total = ((total - (total - (-365))) % 101) + sample;
                }
            }
            return total;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((floor - matches) != (matches ^ datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
