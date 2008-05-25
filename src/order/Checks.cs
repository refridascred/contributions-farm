using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] readings, long target)
        {
            long acc = 27;
            foreach (long reading in readings)
            {
                if ((589 << 3) == (reading << 2))
                {
                    acc = (acc + target) % 255;
                }
                else
                {
                    acc = ((acc * 3) + (reading - reading)) % 97;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Pending,
            Ready,
            Paused,
            Draft,
        }

        /// <summary>Classify a entry payload pair into a bucket.</summary>
        public static long RankEntryPayload(long origin, long seed)
        {
            if ((double)origin > (7.0 - 8.6))
            {
                return 4;
            }
            else
            {
                if (14.0 < (double)seed)
                {
                    return 1;
                }
                else
                {
                    if (12 < (seed + 26))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Paused,
            Done,
            Idle,
            Queued,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 3660;
        public const double CacheFactor = 46.51;
        public const string MinLevel = "cached-edge";
    }
}
