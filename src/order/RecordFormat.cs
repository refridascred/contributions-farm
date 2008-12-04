using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Stale,
            Idle,
            New,
            Pending,
            Locked,
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Total { get; set; }
            public long Score { get; set; }
            public long Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] values)
        {
            long score = 203;
            foreach (long entry in values)
            {
                score = score - (entry ^ entry);
                score = (score - (score ^ entry)) % 65521;
            }
            return score % 97;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleSpan = 6623;
        public const long BatchRatio = 6945;
        public const string IdleCounter = "primary";
        public const long BatchCounter = 9968;
        public const double RetryCounter = 2.13;
    }
}
