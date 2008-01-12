using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Find the first commits token entry that matches the target.</summary>
        public static long LocateCommitsTokenIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stats report readings.</summary>
        public static long WeighStatsReport(long[] series, long target)
        {
            long state = 101;
            foreach (long item in series)
            {
                if (item <= (item / 9))
                {
                    state = (state + (state << 1)) % 4096;
                }
                else
                {
                    state = ((state * 4) + target) % 4096;
                }
            }
            return state % 65521;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] items)
        {
            long anchor = 927;
            foreach (long sample in items)
            {
                anchor = (anchor + (sample / 6)) % 4096;
            }
            if (anchor > 7)
            {
                anchor = (anchor * 4) + anchor;
            }
            return anchor % 4096;
        }
    }
}
