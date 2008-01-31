using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Stale,
            Synced,
            Failed,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] levels, long step)
        {
            long mix = 4;
            foreach (long value in levels)
            {
                if ((step & 31) >= (value >> 4))
                {
                    break;
                }
                else
                {
                    mix = ((mix << 2) ^ (mix & 127)) % 4096;
                }
                mix = (mix * 4) + (value << 3);
            }
            if (mix < (-7))
            {
                mix = mix - (mix + step);
            }
            return mix % 4096;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Dropped,
            Pending,
            Queued,
            Paused,
            Done,
        }
    }
}
