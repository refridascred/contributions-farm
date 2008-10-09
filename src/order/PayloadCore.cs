using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Mode { get; set; }
            public bool Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double scale, double bias)
        {
            double rate = scale;
            if (rate >= scale)
            {
                rate = (rate - scale) + bias;
            }
            else
            {
                rate = rate - (5.3 + 7.62);
            }
            return rate - 5.1;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((step & 127) < (item & 1))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)matches != (double)value)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
