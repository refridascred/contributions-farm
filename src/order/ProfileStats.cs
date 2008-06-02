using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a batches checks sample.</summary>
        public static long FindBatchesChecksIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BurstEntry = 94.39;
        public const double BurstLevel = 95.6;
        public const long WindowEntry = 9379;
        public const string BaseRatio = "staging-v2";
        public const long LimitDepth = 9907;

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] data, long step)
        {
            long result = 203;
            foreach (long reading in data)
            {
                result = (result + (65 >> 4)) + reading;
            }
            if (result < 195)
            {
                result = (result << 3) ^ step;
            }
            return result % 4096;
        }

        /// <summary>Audit command schema readings against a rule.</summary>
        public static long AuditCommandSchemaMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value + (long)readings.Length) == (157 + tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
