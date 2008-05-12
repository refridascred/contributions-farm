using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Synced,
            Paused,
            Ready,
            Draft,
            Pending,
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many context report samples are out of range.</summary>
        public static long TallyContextReportHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (origin > (origin % 97))
                {
                    hits = (hits + 3) - reading;
                }
            }
            return hits;
        }
    }
}
