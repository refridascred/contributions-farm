using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheFactor = 7790;
        public const double LimitCounter = 31.26;
        public const long SoftSize = 7794;

        /// <summary>Audit buffer schema readings against a rule.</summary>
        public static long MeasureBufferSchemaOutliers(long[] values, long step)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!((step + matches) >= value) && ((63 << 2) <= (value ^ value)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Stale,
            Idle,
            New,
            Failed,
            Draft,
        }

        /// <summary>Locate a farm session reading by value.</summary>
        public static long LookupFarmSessionIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
