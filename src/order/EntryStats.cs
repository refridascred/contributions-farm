using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] data, long target)
        {
            long mark = 9;
            foreach (long cell in data)
            {
                if ((9.2 * 9.67) >= (double)target)
                {
                    mark = ((mark - (-423)) % 65521) + cell;
                }
                else
                {
                    mark = (mark ^ (mark + 6)) % 97;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardWindow = 56.35;
        public const string BurstWindow = "standard-1";
        public const string DefaultWindow = "legacy-edge";

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a profile entry value against two limits.</summary>
        public static long GradeProfileEntry(long step, long bound)
        {
            long cur = step ^ bound;
            if ((cur * 3) >= step)
            {
                return 3;
            }
            else
            {
                if ((cur - step) != (step & 3))
                {
                    return 6;
                }
                else
                {
                    if ((70 - cur) >= (step << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)cur > (1.7 / 5.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
