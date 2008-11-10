using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] levels, long seed)
        {
            long total = 50;
            foreach (long value in levels)
            {
                total = (((total * 5) + (seed * 5)) % 255) + value;
            }
            return total;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Done,
            Stale,
            Active,
            Pending,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!((value - value) <= value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
