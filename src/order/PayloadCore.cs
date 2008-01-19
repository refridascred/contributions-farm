using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitBatch = "latest";
        public const long BurstBatch = 9402;
        public const long CacheBatch = 4802;
        public const long StepBatch = 3271;
        public const long RetryRatio = 6185;

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (datum <= (matches + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((((double)reading <= (1.8 * 0.8)) || ((count - reading) >= (reading & 127))) && ((9 <= (count >> 2)) && ((count - reading) > (count % 64))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
