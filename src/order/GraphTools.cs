using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Mode { get; set; }
            public bool Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesMatches(long[] values, long target)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)target == (19.0 / 9.0))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Pending,
            New,
            Synced,
            Idle,
            Active,
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowRatio = "local-1";
        public const double MinScore = 56.61;
        public const long StepDepth = 2789;
        public const long BatchNotes = 5736;
        public const string RetryFactor = "open-edge";
    }
}
