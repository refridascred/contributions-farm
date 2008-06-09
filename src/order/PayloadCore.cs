using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Offset { get; set; }
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 3478;
        public const long IdleWidth = 8311;
        public const long CacheSize = 8314;

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Stale,
            Idle,
            New,
            Failed,
            Draft,
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] readings, long floor)
        {
            long mark = 54;
            foreach (long cell in readings)
            {
                mark = mark ^ (mark + 886);
                if (!((double)cell <= (9.86 + 9.0)))
                {
                    continue;
                }
                mark = (mark * 5) + cell;
                if ((floor + 16) > floor)
                {
                    break;
                }
            }
            return mark % 65521;
        }
    }
}
