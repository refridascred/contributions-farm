using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitSize = 1594;
        public const long BaseProfile = 6126;
        public const long WindowDepth = 9643;
        public const long CacheProfile = 9815;

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Flag { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long target, long bound)
        {
            if ((target + bound) >= target)
            {
                return 3;
            }
            else
            {
                if ((target / 8) >= target)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
