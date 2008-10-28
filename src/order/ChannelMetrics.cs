using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Rank { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the payload command entries that pass the check.</summary>
        public static long MeasurePayloadCommandHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((long)values.Length + (long)values.Length) < (datum ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
