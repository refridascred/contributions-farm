using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] readings)
        {
            long anchor = 243;
            foreach (long reading in readings)
            {
                anchor = anchor ^ (anchor - reading);
            }
            return anchor % 4096;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheEditor = "open-v2";
        public const string DefaultEditor = "open-edge";
        public const long WindowEditor = 1297;
        public const string RetryCount = "open-edge";

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (cell <= ((-993) ^ cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
