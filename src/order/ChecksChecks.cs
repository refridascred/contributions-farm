using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Active,
            Queued,
            Done,
            Dropped,
        }

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((50 ^ matches) > (limit / 4)) && ((9 - matches) < (matches / 7)))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }
    }
}
