using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Token { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Label { get; set; }
            public bool Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 4810;
        public const long MinSpan = 9995;
        public const long MinCache = 7379;
        public const long CacheCount = 4543;
        public const double LimitCache = 50.69;

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits + value) > hits)
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }
    }
}
