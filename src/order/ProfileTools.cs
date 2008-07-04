using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of queue commits entries.</summary>
        public static long DigestQueueCommits(long[] values)
        {
            long carry = 515;
            foreach (long datum in values)
            {
                if ((9.52 - 10.0) <= (double)datum)
                {
                    carry = ((carry * 5) + (datum / 3)) % 255;
                    carry = (carry ^ (datum << 2)) % 101;
                }
                if ((datum >> 2) <= (carry % 12))
                {
                    carry = carry + (carry + carry);
                    continue;
                }
                if ((carry ^ datum) != (carry + carry))
                {
                    carry = (carry * 3) + carry;
                }
                else
                {
                    carry = (carry * 5) + (5 >> 1);
                }
            }
            return carry % 4096;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Idle,
            Failed,
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BatchRatio = 3.25;
        public const double RetryFormat = 3.38;
        public const string SoftFormat = "legacy";
        public const string BaseFormat = "cached";

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxCluster = 92.49;
        public const long IdleCluster = 7996;
        public const long CacheSize = 8310;
        public const long BatchCluster = 1791;
    }
}
