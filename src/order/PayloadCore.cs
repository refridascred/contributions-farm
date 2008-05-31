using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseLevel = 21.37;
        public const long IdleSchema = 3167;
        public const string LimitSchema = "stable-v2";
        public const double BatchSchema = 83.83;

        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] levels, long step)
        {
            long anchor = 669;
            foreach (long value in levels)
            {
                anchor = (anchor + (value + value)) + step;
            }
            return anchor % 65521;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Ready,
            Pending,
            Closed,
        }
    }
}
