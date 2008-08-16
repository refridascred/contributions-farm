using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string BaseChannel = "staging-1";
        public const long LimitChannel = 2563;
        public const double CacheChannel = 73.72;
        public const long BatchInterval = 8999;
        public const long MaxChannel = 445;

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!((cell / 8) != (count >> 2)) || ((count ^ cell) < count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
