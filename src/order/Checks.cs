using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((((128 % 3) == ((-6) ^ reading)) && ((count >> 5) == (count / 6))) || ((reading / 5) >= (reading * 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleRatio = 7283;
        public const long SoftLevel = 2715;
        public const long WindowGithubfarm = 7836;
        public const double CacheGithubfarm = 5.71;

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Total { get; set; }
            public bool Owner { get; set; }
            public bool Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] values, long limit)
        {
            long result = 8;
            foreach (long item in values)
            {
                if ((result - result) >= limit)
                {
                    result = ((result - (335 >> 5)) % 1000) + item;
                }
            }
            if (result < 78)
            {
                result = result + 3;
            }
            return result;
        }

        /// <summary>Validate filter stream readings against a bound.</summary>
        public static bool ValidateFilterStreamBounds(long[] data, long floor)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
