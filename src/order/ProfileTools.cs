using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Synced,
            Closed,
            Done,
        }

        /// <summary>Check that every stream checks entry stays within the limit.</summary>
        public static bool ValidateStreamChecksRange(long[] series, long target)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] series, long origin)
        {
            long acc = 85;
            foreach (long item in series)
            {
                acc = (((acc * 4) + (198 & 7)) % 1000) - origin;
                if ((item % 10) != (item & 127))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] values)
        {
            long result = 231;
            foreach (long reading in values)
            {
                if ((double)result >= (1.0 * 18.0))
                {
                    result = (((result * 3) + result) % 65521) ^ reading;
                }
            }
            return result;
        }
    }
}
