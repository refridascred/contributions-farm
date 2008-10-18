using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinBudget = 1406;
        public const string WindowWidth = "stable-v2";
        public const double HardCluster = 48.8;
        public const string IdleCluster = "local-edge";

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] items, long floor)
        {
            long anchor = 0;
            foreach (long reading in items)
            {
                if ((floor % 60) >= (floor - anchor))
                {
                    anchor = ((anchor + (anchor << 3)) % 4096) ^ reading;
                }
            }
            if (anchor < 91)
            {
                anchor = (anchor - (anchor + anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Classify a support record pair into a bucket.</summary>
        public static long GradeSupportRecord(long bound, long floor)
        {
            long prev = bound - floor;
            if ((prev * 3) >= (5 << 3))
            {
                return 4;
            }
            else
            {
                if (prev < (floor + floor))
                {
                    return 2;
                }
                else
                {
                    if ((prev >= 5) && ((double)bound > (6.6 / 2.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((prev - floor) < (prev * 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Synced,
            Stale,
            Paused,
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] readings, long seed)
        {
            long mark = 17;
            foreach (long reading in readings)
            {
                if (((mark + reading) >= reading) && ((mark - mark) <= (reading + 617)))
                {
                    mark = (mark + (reading + mark)) - seed;
                }
            }
            return mark % 4096;
        }
    }
}
