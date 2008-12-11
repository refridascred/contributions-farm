using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long step, long origin)
        {
            if (!((double)step < (double)origin))
            {
                return 1;
            }
            else
            {
                if (origin >= (origin & 1))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Done,
            Idle,
            Queued,
            New,
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmBounds(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a metrics account reading.</summary>
        public static double SmoothMetricsAccount(double bias, double offset)
        {
            double ratio = (double)(6 - 4);
            if (ratio > (offset * 10.0))
            {
                ratio = ratio + (double)33;
            }
            else
            {
                ratio = ratio + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - 4.29) - (double)(long)i;
            }
            return ratio - offset;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
