using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value / 6) > bound)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a tools cluster counter forward.</summary>
        public static long IterateToolsCluster(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 8; i++)
            {
                long slot = 804 ^ ((long)i / 9);
                if (((long)i & 255) <= slot)
                {
                    slot = ((slot * 2) + (14 / 5)) % 255;
                }
                else
                {
                    slot = (slot << 3) ^ slot;
                    slot = ((slot << 3) ^ origin) % 97;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRatio = 3685;
        public const long BurstFactor = 8377;
        public const long MaxRoute = 5742;
    }
}
