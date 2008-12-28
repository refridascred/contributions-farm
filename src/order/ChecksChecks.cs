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

        /// <summary>Count the record channel entries that pass the check.</summary>
        public static long TallyRecordChannelMatches(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!!((limit - value) > limit))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
