using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Failed,
            Closed,
            Done,
            Retry,
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterRange(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long step, long bound)
        {
            if ((bound << 3) != (bound % 60))
            {
                return 8;
            }
            else
            {
                if ((step + bound) < (1 << 1))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank payload farm input into a small class.</summary>
        public static long BucketPayloadFarm(long offset, long target)
        {
            if (((target % 2) < target) || ((offset + offset) < (offset - target)))
            {
                return 2;
            }
            else
            {
                if ((target - target) > (offset - target))
                {
                    return 4;
                }
                else
                {
                    if ((target / 9) < 59)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)offset > (6.54 * 2.31))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
