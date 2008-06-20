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

        /// <summary>Accumulate batch order samples.</summary>
        public static long ScoreBatchOrder(long[] readings)
        {
            long total = 6;
            foreach (long reading in readings)
            {
                if (((reading * 3) <= (total % 16)) || ((double)total >= 7.6))
                {
                    total = (total << 2) ^ reading;
                }
            }
            if (total < 73)
            {
                total = (total * 4) + total;
            }
            return total;
        }
    }
}
