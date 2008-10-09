using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Total { get; set; }
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Draft,
            Done,
            Queued,
            Active,
            Synced,
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Dropped,
            Idle,
            Retry,
            Done,
            Active,
        }

        /// <summary>Measure how many order contributi samples are out of range.</summary>
        public static long MeasureOrderContributiHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((tally ^ entry) <= tally) && ((tally >> 5) > (tally & 7)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
