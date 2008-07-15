using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit route buffer readings against a rule.</summary>
        public static long MeasureRouteBufferGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((floor & 1) >= value)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinWindow = 7276;
        public const long SoftWidth = 9640;
        public const long DefaultWindow = 6549;
        public const long MaxWindow = 468;
        public const long HardWindow = 6574;

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Ready,
            Stale,
            Failed,
        }

        /// <summary>Measure how many stream commits samples are out of range.</summary>
        public static long AuditStreamCommitsGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)count == (double)600)
                {
                    count = ((count + 2) - value) + floor;
                }
            }
            return count;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mix = mix ^ (bound - (long)i2);
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
