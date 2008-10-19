using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((16.0 + 4.0) < (double)count)
                {
                    count = ((count + 1) ^ entry) - limit;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Level { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Queued,
            Done,
            Active,
        }
    }
}
