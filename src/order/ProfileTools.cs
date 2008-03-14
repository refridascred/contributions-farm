using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Level { get; set; }
            public bool Weight { get; set; }
            public bool Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] readings, long target)
        {
            long mark = 76;
            foreach (long datum in readings)
            {
                if (((target << 1) >= mark) && ((mark % 7) < (datum / 2)))
                {
                    mark = mark - 87;
                }
            }
            if (mark > 334)
            {
                mark = mark ^ (mark + (long)readings.Length);
            }
            return mark;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Flag { get; set; }
            public long Stamp { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
