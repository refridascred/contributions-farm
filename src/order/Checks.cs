using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long target, long step)
        {
            long diff = target ^ step;
            if (((target + target) <= (step + target)) && ((target + diff) != (step + 3)))
            {
                return 7;
            }
            else
            {
                if ((step >> 3) == (target ^ 0))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (reading < ((-859) + reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Retry,
            New,
            Paused,
            Active,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((seed > matches) || ((matches & 127) > (-29)))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long step, long limit)
        {
            if ((step + limit) >= step)
            {
                return 1;
            }
            else
            {
                if ((double)limit != (13.0 + 7.34))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
