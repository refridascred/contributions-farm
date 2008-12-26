using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Weight { get; set; }
            public double Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!((tally ^ tally) == (tally >> 2)))
                {
                    tally = ((tally + 2) + item) - step;
                }
            }
            return tally;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (cell <= (cell - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
