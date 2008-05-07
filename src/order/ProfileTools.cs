using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            New,
            Dropped,
            Queued,
            Pending,
            Active,
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCount = 4893;
        public const long RetryTimeout = 2086;
        public const double StepCache = 95.41;
        public const string SoftWidth = "latest-v2";

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Size { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
