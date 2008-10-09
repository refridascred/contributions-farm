using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((((-48) + 250) <= (step ^ reading)) || ((reading & 3) >= (122 / 7)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Owner { get; set; }
            public double Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Compare every pair of editor account readings.</summary>
        public static long OverlapEditorAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
