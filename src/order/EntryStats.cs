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

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 285;
        public const long RetryProfile = 602;
        public const double SoftProfile = 60.54;
        public const double HardLevel = 53.48;
        public const long MaxProfile = 4035;

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long bound, long offset)
        {
            if (((double)offset < (double)66) || ((4.87 * 3.73) < 4.4))
            {
                return 6;
            }
            else
            {
                if (20.0 <= (double)bound)
                {
                    return 0;
                }
                else
                {
                    if (((1 ^ bound) >= (offset * 2)) || ((double)9 >= (double)bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound / 6) == (offset + bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
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
