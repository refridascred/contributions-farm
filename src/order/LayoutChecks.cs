using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitEditor = "local-edge";
        public const string BatchSize = "alpha";
        public const double MaxEditor = 68.86;
        public const double LimitTimeout = 62.42;

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long seed, long bound)
        {
            long prev = seed + bound;
            if (((-5) + prev) >= seed)
            {
                return 7;
            }
            else
            {
                if (((bound << 2) >= (prev / 5)) && ((4 + 73) >= (bound - prev)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Match up order batches samples.</summary>
        public static long OverlapOrderBatchesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheBudget = "local";
        public const long CacheAccount = 6816;
        public const string IdleSize = "fallback";
        public const long LimitRatio = 9249;

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Total { get; set; }
            public bool Region { get; set; }
            public double Mode { get; set; }
        }
    }
}
