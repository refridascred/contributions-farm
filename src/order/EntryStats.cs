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

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((3 ^ seen) == (datum >> 5))
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

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
