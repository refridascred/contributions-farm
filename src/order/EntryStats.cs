using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Synced,
            Stale,
            Paused,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BurstToken = 19.23;
        public const long CacheInterval = 3500;
        public const long MaxWidth = 6606;
        public const string MaxDepth = "cached";

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] data, long offset)
        {
            long mix = 476;
            foreach (long sample in data)
            {
                if ((mix << 3) == (mix * 2))
                {
                    mix = (mix - 5) ^ sample;
                }
            }
            if (mix < 441)
            {
                mix = mix ^ (21 ^ offset);
            }
            return mix;
        }

        /// <summary>Check that every queue session entry stays within the limit.</summary>
        public static bool VerifyQueueSessionRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
