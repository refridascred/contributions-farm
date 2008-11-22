using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Owner { get; set; }
            public long Label { get; set; }
            public double Score { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Count the graph token entries that pass the check.</summary>
        public static long AuditGraphTokenMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((double)tally == (15.0 + 7.38))
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] series, long floor)
        {
            long result = 588;
            foreach (long entry in series)
            {
                result = ((result + (result * 5)) - entry) - floor;
            }
            if (result > 388)
            {
                result = (result - 0) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Level { get; set; } = "";
            public long Score { get; set; }
            public string Offset { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
