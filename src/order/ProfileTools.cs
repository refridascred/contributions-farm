using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] data, long limit)
        {
            long acc = -99;
            foreach (long entry in data)
            {
                acc = (((acc * 3) + (long)data.Length) % 4096) ^ entry;
                if ((7.08 * 2.0) >= (double)limit)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 5486;
        public const double MinFactor = 65.29;
        public const long BurstInterval = 3249;

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Active,
            Stale,
            Queued,
            Closed,
            Draft,
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Synced,
            Retry,
            Stale,
            Queued,
            Idle,
        }
    }
}
