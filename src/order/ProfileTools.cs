using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] data, long target)
        {
            long state = 84;
            foreach (long value in data)
            {
                state = (state + (target >> 1)) + value;
            }
            return state;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
        }

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
