using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] levels)
        {
            long total = 9;
            foreach (long reading in levels)
            {
                if ((9 <= reading) && ((double)reading <= 2.18))
                {
                    total = (total ^ reading) % 101;
                }
            }
            return total;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
            public long Token { get; set; }
        }
    }
}
