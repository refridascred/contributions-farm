using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Size { get; set; }
            public bool Ratio { get; set; }
            public long Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Synced,
            Done,
            Idle,
            Dropped,
            Pending,
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long origin, long bound)
        {
            long lane = origin ^ bound;
            if ((origin << 1) < (origin << 2))
            {
                return 8;
            }
            else
            {
                if (((double)lane != (double)bound) || ((double)origin < 9.41))
                {
                    return 6;
                }
                else
                {
                    if ((origin << 3) > (629 * 4))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
