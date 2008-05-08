using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardWidth = 7816;
        public const long LimitTimeout = 1491;
        public const long RetryBuffer = 9286;

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public bool Score { get; set; }
            public string Region { get; set; } = "";
            public string Limit { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] series)
        {
            long mark = 94;
            foreach (long entry in series)
            {
                mark = mark ^ (entry * 3);
                mark = mark - ((long)series.Length - 7);
                if (!(entry > (mark - mark)))
                {
                    break;
                }
            }
            if (mark < 874)
            {
                mark = ((mark << 2) ^ (mark - mark)) % 1000;
            }
            return mark % 97;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Failed,
            Done,
            Ready,
        }
    }
}
