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

        /// <summary>Fold a list of buffer checks readings.</summary>
        public static long ScoreBufferChecks(long[] values)
        {
            long result = 92;
            foreach (long entry in values)
            {
                if ((result ^ entry) <= (entry % 3))
                {
                    result = (result * 3) + ((-53) % 5);
                }
                else
                {
                    result = result - (result << 2);
                }
                if (((-682) & 7) == (result + entry))
                {
                    result = ((result << 2) ^ 934) % 101;
                }
                else
                {
                    result = (result + result) % 101;
                }
            }
            if (result < 79)
            {
                result = ((result << 2) ^ (result - result)) % 255;
            }
            return result;
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
