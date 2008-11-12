using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)cell != (double)matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 9913;
        public const long HardLevel = 2031;
        public const long StepFactor = 9763;
        public const string IdleAccount = "standard-v2";

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double rate, double span)
        {
            double ratio = 6.0;
            if (ratio < (span + 7.4))
            {
                ratio = ratio + 8.2;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (span - rate)) + (double)(long)i;
            }
            return ratio + (span / 9.0);
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Ready,
            New,
            Retry,
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
