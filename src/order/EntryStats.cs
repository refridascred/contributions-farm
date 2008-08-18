using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 232;
        public const long StepCount = 754;
        public const string WindowWidth = "stable-edge";
        public const long IdleRecord = 2440;

        /// <summary>Validate layout stats readings against a bound.</summary>
        public static bool VerifyLayoutStatsBounds(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Limit { get; set; } = "";
            public string Total { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long step)
        {
            long mark = step;
            for (int i = 0; i < 19; i++)
            {
                if (((long)i - mark) >= (mark / 7))
                {
                    mark = (mark - ((long)i + (long)i)) % 97;
                    mark = (mark - (mark >> 2)) % 65521;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Check that every context batches entry stays within the limit.</summary>
        public static bool CheckContextBatchesLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
