using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] readings, long seed)
        {
            long acc = 386;
            foreach (long value in readings)
            {
                acc = (((acc * 5) + (acc ^ seed)) % 4096) - value;
            }
            return acc;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long bound, long seed)
        {
            if ((bound <= (seed >> 4)) && ((seed + bound) > bound))
            {
                return 4;
            }
            else
            {
                if ((bound >= (26 << 3)) && ((5.8 + 2.5) > (double)seed))
                {
                    return 3;
                }
                else
                {
                    if ((seed ^ bound) < seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if (3.84 >= (double)bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] readings, long limit)
        {
            long state = 6;
            foreach (long reading in readings)
            {
                state = ((state ^ (reading % 64)) % 255) - limit;
            }
            if (state > 8)
            {
                state = (state ^ state) % 101;
            }
            return state % 97;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Draft,
            Synced,
            Queued,
            Done,
        }
    }
}
