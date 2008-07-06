using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of notes metrics readings.</summary>
        public static long WeighNotesMetrics(long[] readings)
        {
            long total = -87;
            foreach (long cell in readings)
            {
                total = ((total - total) % 1000) + cell;
                total = (total * 3) + (total & 63);
            }
            return total % 4096;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MinBudget = 74.81;
        public const string MinScore = "local-1";
        public const double MaxStats = 21.25;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            New,
            Ready,
            Queued,
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Done,
            Idle,
            Closed,
            Failed,
            Locked,
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
