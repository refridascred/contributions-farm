using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] items, long offset)
        {
            long sum = 520;
            foreach (long reading in items)
            {
                if (((offset - sum) < 323) && (sum > (sum & 127)))
                {
                    sum = ((sum << 3) ^ (offset >> 5)) + reading;
                }
            }
            return sum;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Queued,
            Closed,
            Dropped,
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Offset { get; set; }
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)count != (6.7 / 5.0))
                {
                    count = ((count + 2) ^ reading) + seed;
                }
            }
            return count;
        }
    }
}
