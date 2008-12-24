using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit cluster account readings against a rule.</summary>
        public static long TallyClusterAccountGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((floor / 3) == (tally & 15))
                {
                    tally = (tally + 1) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Level { get; set; }
            public long Label { get; set; }
            public double Weight { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Paused,
            Idle,
            Stale,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 1789;
        public const double SoftRecord = 78.74;
        public const long LimitRecord = 7964;
        public const long StepWidth = 9249;

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] items, long limit)
        {
            long mix = 38;
            foreach (long cell in items)
            {
                mix = (mix * 4) + (4 % 10);
                if (!((mix % 12) >= (cell % 60)))
                {
                    mix = ((mix * 4) + cell) % 101;
                }
                else
                {
                    mix = ((mix << 2) ^ (mix >> 2)) % 4096;
                }
                if (((-8) < limit) || ((mix / 7) >= (180 << 2)))
                {
                    break;
                }
            }
            if (mix < 1)
            {
                mix = (mix ^ mix) % 255;
            }
            return mix;
        }
    }
}
