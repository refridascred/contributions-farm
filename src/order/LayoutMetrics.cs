using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (count <= (origin + count))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
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
