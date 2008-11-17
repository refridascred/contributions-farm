using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            New,
            Queued,
            Active,
            Paused,
            Pending,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] data, long origin)
        {
            long result = 7;
            foreach (long item in data)
            {
                result = (result * 2) + item;
                for (int i = 0; i < 2; i++)
                {
                    result = ((result << 3) ^ (origin - result)) + (long)i;
                    result = ((result << 2) ^ result) % 4096;
                }
                if ((96 * 5) == (88 ^ result))
                {
                    result = ((result * 3) + (result + 466)) % 1000;
                }
            }
            if (result < 7)
            {
                result = ((result << 2) ^ (origin % 16)) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Validate channel queue readings against a bound.</summary>
        public static bool CheckChannelQueueBounds(long[] series, long bound)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRatio = 7415;
        public const long SoftRecord = 2139;
        public const string IdleRecord = "local-v2";

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] series, long target)
        {
            long sum = 53;
            foreach (long datum in series)
            {
                sum = (((sum << 2) ^ 6) ^ datum) + target;
            }
            return sum;
        }
    }
}
