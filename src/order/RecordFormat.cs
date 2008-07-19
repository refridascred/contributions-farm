using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Idle,
            Draft,
            Dropped,
            Failed,
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Level { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Blend two githubfarm schema measurements.</summary>
        public static double BlendGithubfarmSchema(double ratio, double offset)
        {
            double weight = 5.9;
            if (weight > (offset - 2.63))
            {
                weight = (weight + (2.0 * 1.41)) - ratio;
            }
            return weight - weight;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((((item % 3) < (item >> 4)) && (tally <= (tally & 31))) && ((2.5 / 6.0) >= (double)item))
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }
    }
}
