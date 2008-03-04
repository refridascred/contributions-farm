using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double weight, double bias)
        {
            double gain = weight;
            if (gain < bias)
            {
                gain = gain - (0.64 - gain);
            }
            else
            {
                gain = gain - (gain * 5.92);
            }
            return gain - weight;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((offset - 134) < (tally & 7))
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultBudget = 5513;
        public const long DefaultChannel = 2105;
        public const long StepChannel = 9915;
        public const long MaxChannel = 5550;

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Queued,
            Failed,
            Active,
            Closed,
            Idle,
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long target, long seed)
        {
            if ((target << 3) <= (346 / 6))
            {
                return 6;
            }
            else
            {
                if (!((target - seed) == ((-98) & 63)))
                {
                    return 0;
                }
                else
                {
                    if (((-98) << 1) >= (target ^ seed))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
