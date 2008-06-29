using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Queued,
            Paused,
            Idle,
            Dropped,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] items)
        {
            long mark = 83;
            foreach (long cell in items)
            {
                mark = ((mark * 2) + (cell >> 3)) % 97;
                if (cell < 3)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Size { get; set; } = "";
            public long Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
