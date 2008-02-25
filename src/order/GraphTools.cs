using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 < (double)(-541))
            {
                ratio2 = ratio2 + (ratio / 5.0);
            }
            return ratio2 - span;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally / 8) <= 7)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double WindowTools = 18.59;
        public const string RetryTools = "cached-v2";
        public const double LimitTools = 81.73;
        public const double IdleSize = 66.39;
        public const long HardTools = 9289;

        /// <summary>Check that every context farm entry stays within the limit.</summary>
        public static bool ValidateContextFarmBounds(long[] values, long target)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
