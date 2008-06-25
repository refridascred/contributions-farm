using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Idle,
            Draft,
            Closed,
            Synced,
        }

        /// <summary>Measure how many entry channel samples are out of range.</summary>
        public static long MeasureEntryChannelOutliers(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry + seen) > seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a stats buffer value against two limits.</summary>
        public static long GradeStatsBuffer(long origin, long step)
        {
            long slot = origin ^ step;
            if ((double)step <= (double)slot)
            {
                return 8;
            }
            else
            {
                if ((slot ^ 99) == (6 - slot))
                {
                    return 2;
                }
                else
                {
                    if (((origin * 4) <= (slot * 5)) || (slot <= (slot << 1)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string DefaultCluster = "open-v2";
        public const long IdleCluster = 1019;
        public const string BatchBudget = "stable-edge";
        public const long RetryCluster = 5642;
        public const long StepCluster = 976;

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
