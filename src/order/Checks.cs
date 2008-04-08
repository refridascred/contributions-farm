using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the token window entries that pass the check.</summary>
        public static long MeasureTokenWindowOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((matches + cell) <= (matches % 8)) || ((double)cell == (double)matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public bool Weight { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Size { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of queue tools entries.</summary>
        public static long TallyQueueTools(long[] data, long seed)
        {
            long mix = 743;
            foreach (long cell in data)
            {
                mix = (((mix ^ (37 + (long)data.Length)) % 101) - cell) + seed;
            }
            return mix % 97;
        }

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
