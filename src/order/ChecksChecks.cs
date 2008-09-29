using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the stats stream entries that pass the check.</summary>
        public static long CountStatsStreamHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((1 * 4) > (matches % 100))
                {
                    matches = (matches + 1) - value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordGaps(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((2 << 1) >= (datum + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Size { get; set; }
            public double Count { get; set; }
        }
    }
}
