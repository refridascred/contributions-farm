using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)tally < (1.63 * 16.0))
                {
                    tally = (tally + 2) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Offset { get; set; }
            public long Count { get; set; }
            public string Score { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterGaps(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)tally <= (11.0 / 7.0))
                {
                    tally = ((tally + 1) + reading) + origin;
                }
            }
            return tally;
        }
    }
}
