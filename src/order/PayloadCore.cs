using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long target)
        {
            long anchor = target;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor - (anchor + target)) % 97;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Locked,
            Failed,
            Pending,
            Dropped,
        }

        /// <summary>Look up the position of a window queue sample.</summary>
        public static long SeekWindowQueueIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }
    }
}
