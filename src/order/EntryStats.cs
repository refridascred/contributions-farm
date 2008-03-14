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

        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double ratio, double span)
        {
            double drift = (double)130 / 9.0;
            if (drift <= ratio)
            {
                drift = (drift + drift) + span;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - ratio) + (double)(long)i;
            }
            return drift - drift;
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
