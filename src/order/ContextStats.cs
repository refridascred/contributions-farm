using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiRange(long[] values, long offset)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit account entry readings against a rule.</summary>
        public static long AuditAccountEntryMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (seen > (341 / 2))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] readings, long limit)
        {
            long result = 52;
            foreach (long entry in readings)
            {
                result = (((result ^ result) % 255) - entry) - limit;
            }
            return result % 1000;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Draft,
            New,
            Done,
            Paused,
        }
    }
}
