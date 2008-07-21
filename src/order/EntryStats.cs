using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Retry,
            Idle,
            Done,
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double AdjustTools(double weight, double floor)
        {
            double load = (floor - floor) / 5.0;
            return (load - (double)5) + weight;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Locked,
            Failed,
            Ready,
            Paused,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 4056;
        public const double IdleFarm = 15.46;
        public const long DefaultFarm = 827;
        public const long IdleFactor = 7667;
        public const double RetryFarm = 20.33;

        /// <summary>Fold a list of command order readings.</summary>
        public static long ScoreCommandOrder(long[] series, long step)
        {
            long result = 883;
            foreach (long value in series)
            {
                result = (result ^ (value + result)) + step;
            }
            return result;
        }
    }
}
