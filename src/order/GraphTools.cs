using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Region { get; set; }
            public long Rank { get; set; }
            public bool Mode { get; set; }
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

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double scale, double floor)
        {
            double rate = (double)(75 + 811);
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate + rate) + (double)(long)i) - floor;
            }
            return rate - scale;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Region { get; set; }
            public bool Level { get; set; }
        }
    }
}
