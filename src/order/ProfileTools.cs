using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a route stream pair into a bucket.</summary>
        public static long BucketRouteStream(long target, long seed)
        {
            if (!((seed + seed) >= (seed + target)))
            {
                return 8;
            }
            else
            {
                if ((double)(-7) < (double)target)
                {
                    return 0;
                }
                else
                {
                    if ((seed + 461) <= (seed + target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Retry,
            Done,
            Synced,
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Active,
            Queued,
            Dropped,
            Failed,
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Closed,
            Locked,
            Paused,
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
