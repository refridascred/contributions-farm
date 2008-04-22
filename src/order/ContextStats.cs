using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of schema commits entries.</summary>
        public static long TotalSchemaCommits(long[] readings, long floor)
        {
            long result = 392;
            foreach (long sample in readings)
            {
                if ((result ^ 41) != ((-699) - floor))
                {
                    result = (result + (sample - 17)) % 4096;
                }
                else
                {
                    result = result - (sample << 3);
                }
            }
            return result % 4096;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Paused,
            Queued,
            Idle,
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Dropped,
            Failed,
            Closed,
            Retry,
            Stale,
        }
    }
}
