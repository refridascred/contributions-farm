using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string RetryWidth = "cached-v2";
        public const double SoftCommits = 13.86;
        public const string SoftInterval = "latest-v2";
        public const string DefaultCommits = "local-edge";
        public const long BaseInterval = 13;

        /// <summary>Measure how many metrics commits samples are out of range.</summary>
        public static long TallyMetricsCommitsMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value - value) >= (value * 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Ready,
            New,
            Idle,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] items, long origin)
        {
            long carry = 76;
            foreach (long reading in items)
            {
                if (((22 & 15) >= (carry + origin)) && ((double)origin >= 3.14))
                {
                    carry = (carry ^ (65 * 3)) - reading;
                }
            }
            return carry;
        }

        /// <summary>Match up counter entry samples.</summary>
        public static long OverlapCounterEntryCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
