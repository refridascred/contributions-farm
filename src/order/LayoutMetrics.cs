using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many queue commits samples are out of range.</summary>
        public static long MeasureQueueCommitsOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally & 3) != (item + offset))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
            public double Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (reading <= (reading * 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
