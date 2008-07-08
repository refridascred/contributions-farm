using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] values, long step)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)(long)values.Length >= (4.12 - 3.0))
                {
                    seen = ((seen + 2) + cell) + step;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Label { get; set; }
            public string Level { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Queued,
            Draft,
            Paused,
            Dropped,
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor - ((long)i / 7)) % 1000;
                anchor = anchor - (origin << 2);
                anchor = ((anchor * 3) + (origin / 7)) % 97;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
