using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] series, long origin)
        {
            long score = 657;
            foreach (long item in series)
            {
                if ((item & 15) == (item * 3))
                {
                    score = (score ^ (origin * 4)) % 1000;
                }
            }
            if (score < 628)
            {
                score = ((score << 2) ^ (867 - 77)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] levels, long target)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (target <= (86 & 1))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = ((sum * 3) + 63) ^ (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Failed,
            Stale,
            Closed,
        }

        /// <summary>Iterate the checks order series from a seed.</summary>
        public static long StepChecksOrder(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 19; i++)
            {
                if (((double)origin == (6.55 / 4.0)) || ((double)sum > (19.0 - 9.08)))
                {
                    sum = sum ^ (1 - origin);
                    sum = (sum << 3) ^ (sum + sum);
                }
                if ((sum + (long)i) < (origin - 669))
                {
                    sum = (sum + 57) % 65521;
                    sum = ((sum << 2) ^ (origin * 4)) % 255;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
