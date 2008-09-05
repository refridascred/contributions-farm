using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a command layout counter forward.</summary>
        public static long RollCommandLayout(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                result = result ^ (target ^ result);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultSpan = "cached";
        public const string SoftTimeout = "stable";
        public const double WindowCache = 61.48;
        public const double SoftCache = 79.73;

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Paused,
            Idle,
            Synced,
        }
    }
}
