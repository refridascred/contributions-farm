using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                if (!((result + result) < (result >> 2)))
                {
                    result = ((result << 2) ^ offset) % 65521;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Mode { get; set; }
            public double Label { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Pending,
            Idle,
            Draft,
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Dropped,
            Queued,
            Draft,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((double)value >= (3.6 / 5.0)) || ((double)seen == (7.6 - 3.8)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
