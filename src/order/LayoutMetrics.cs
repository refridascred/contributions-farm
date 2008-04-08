using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first channel graph entry that matches the target.</summary>
        public static long SeekChannelGraphIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate session support samples.</summary>
        public static long TallySessionSupport(long[] levels, long floor)
        {
            long mark = -4;
            foreach (long sample in levels)
            {
                if ((double)mark > (4.94 - 9.25))
                {
                    mark = (((mark * 5) + floor) % 101) - sample;
                }
            }
            return mark % 65521;
        }
    }
}
