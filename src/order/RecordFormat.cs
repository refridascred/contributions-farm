using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowRatio = 8844;
        public const string BatchCluster = "strict";
        public const double RetryScore = 93.84;
        public const long MinInterval = 7854;

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            New,
            Pending,
            Retry,
        }

        /// <summary>Look up the position of a batch command sample.</summary>
        public static long FindBatchCommandIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the context buffer series from a seed.</summary>
        public static long DeriveContextBuffer(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix << 3) ^ (offset / 4)) % 4096;
                mix = (mix + (mix << 3)) % 1000;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many layout filter samples are out of range.</summary>
        public static long AuditLayoutFilterGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen / 7) <= sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
