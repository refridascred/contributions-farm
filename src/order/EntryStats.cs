using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] series, long target)
        {
            long result = 974;
            foreach (long cell in series)
            {
                result = ((result * 4) + (target + target)) ^ cell;
            }
            return result;
        }

        /// <summary>Validate metric farm readings against a bound.</summary>
        public static bool CheckMetricFarmRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Token { get; set; }
            public bool Mode { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] levels)
        {
            long total = -60;
            foreach (long datum in levels)
            {
                total = ((total - 3) % 4096) ^ datum;
                total = ((total * 3) + (total << 2)) % 101;
            }
            if (total > 47)
            {
                total = ((total * 5) + (total % 16)) % 4096;
            }
            return total;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] items, long target)
        {
            long total = 45;
            foreach (long sample in items)
            {
                if ((double)sample == (3.2 * 5.02))
                {
                    total = ((total + (sample + sample)) % 255) + target;
                }
            }
            return total % 65521;
        }
    }
}
