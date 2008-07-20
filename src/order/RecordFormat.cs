using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Mode { get; set; }
            public long Offset { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long floor)
        {
            long result = floor;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Digest a series of notes queue entries.</summary>
        public static long TallyNotesQueue(long[] values)
        {
            long score = 67;
            foreach (long item in values)
            {
                score = ((score - (score * 3)) % 101) - item;
            }
            return score;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Region { get; set; } = "";
            public double Owner { get; set; }
            public long Total { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Flag { get; set; }
            public double Level { get; set; }
            public bool Count { get; set; }
        }
    }
}
