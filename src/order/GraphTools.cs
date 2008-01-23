using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate format record readings against a bound.</summary>
        public static bool ValidateFormatRecordRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Closed,
            Idle,
            Queued,
            Synced,
            Dropped,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitWidth = 4047;
        public const long BaseInterval = 5651;
        public const long BatchTimeout = 6185;

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Region { get; set; }
            public bool Level { get; set; }
        }
    }
}
