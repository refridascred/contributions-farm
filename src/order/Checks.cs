using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Offset { get; set; }
            public double Weight { get; set; }
            public long Stamp { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] values)
        {
            long total = 664;
            foreach (long datum in values)
            {
                total = ((total - 39) % 1000) + datum;
            }
            if (total > 29)
            {
                total = (total * 3) + (total ^ 3);
            }
            return total % 97;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Stale,
            Locked,
            Closed,
            Active,
        }

        /// <summary>Roll a entry record counter forward.</summary>
        public static long RollEntryRecord(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mix = ((mix + mix) % 97) ^ (long)i2;
                }
                mix = ((mix << 3) ^ mix) % 97;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordLimits(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
