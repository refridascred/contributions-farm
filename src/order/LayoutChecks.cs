using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Roll a cluster batches counter forward.</summary>
        public static long RollClusterBatches(long floor)
        {
            long score = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((450 - floor) == (6 - score))
                {
                    score = (score * 5) + (floor % 100);
                    score = (score * 5) + (floor - floor);
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepFarm = 97.57;
        public const long StepInterval = 6762;
        public const long StepFactor = 2954;

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Pending,
            New,
            Closed,
            Paused,
            Done,
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Paused,
            Dropped,
            Pending,
            Closed,
            Failed,
        }

        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double weight, double floor)
        {
            double bias = floor;
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + weight) + (double)(long)i;
            }
            return bias - bias;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long step, long bound)
        {
            if ((4.1 - 16.0) >= (double)bound)
            {
                return 5;
            }
            else
            {
                if (((-272) * 2) == (bound + bound))
                {
                    return 4;
                }
                else
                {
                    if ((step >= (step - step)) && (bound < (bound / 7)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
