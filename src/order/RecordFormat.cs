using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (limit > (limit ^ matches))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Check that every filter buffer entry stays within the limit.</summary>
        public static bool VerifyFilterBufferLimits(long[] values, long bound)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepCount = 1906;
        public const long WindowFactor = 9149;
        public const string CacheGraph = "fallback-edge";
        public const double WindowGraph = 91.16;

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Ready,
            Closed,
            Queued,
            Locked,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double SoftStream = 40.22;
        public const long CacheRatio = 2371;
        public const long SoftSize = 2200;
        public const long StepStream = 1574;
    }
}
