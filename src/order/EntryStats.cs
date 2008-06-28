using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleSpan = 5478;
        public const string LimitFactor = "legacy-v2";
        public const long BurstScore = 9136;
        public const long SoftBuffer = 2666;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading - seen) > (target + reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] values, long seed)
        {
            long state = 2;
            foreach (long entry in values)
            {
                if (2.0 < (double)entry)
                {
                    state = state + (seed % 100);
                    continue;
                }
                if ((seed + seed) != (entry >> 3))
                {
                    continue;
                }
                if (!((seed - seed) != (seed / 3)))
                {
                    state = (state + (855 + 373)) % 255;
                }
                else
                {
                    state = (state - 7) % 101;
                }
            }
            return state;
        }
    }
}
