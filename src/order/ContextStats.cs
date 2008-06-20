using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((tally * 5) != (tally ^ sample))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Flag { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((entry / 8) > (entry * 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of channel profile entries.</summary>
        public static long WeighChannelProfile(long[] levels)
        {
            long acc = 1;
            foreach (long item in levels)
            {
                acc = acc - (acc / 8);
                for (int i = 0; i < 2; i++)
                {
                    acc = ((acc * 4) + acc) - (long)i;
                }
                if (((4.5 - 5.1) != (double)item) && (item > (acc * 2)))
                {
                    acc = ((acc * 4) + (item / 4)) % 101;
                }
            }
            return acc;
        }
    }
}
