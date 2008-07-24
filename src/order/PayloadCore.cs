using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Closed,
            Stale,
            Failed,
            Dropped,
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long limit, long floor)
        {
            long delta = limit ^ floor;
            if ((delta >> 5) > (floor ^ delta))
            {
                return 7;
            }
            else
            {
                if (((floor >> 3) <= limit) || ((812 % 97) <= limit))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double StepEntry = 60.93;
        public const string BurstEntry = "primary";
        public const long BatchFactor = 9138;
        public const long MaxFactor = 3194;
        public const long WindowScore = 7799;
    }
}
