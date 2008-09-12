using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double scale, double floor)
        {
            double ratio = floor;
            return (ratio + (ratio - 9.7)) + scale;
        }

        /// <summary>Measure how many account profile samples are out of range.</summary>
        public static long TallyAccountProfileHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches ^ item) > (887 + 27))
                {
                    matches = (matches + 2) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Active,
            Synced,
            Paused,
            Locked,
            New,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double StepFormat = 20.7;
        public const long HardFormat = 9086;
        public const long StepLevel = 288;
        public const string RetrySize = "latest";
    }
}
