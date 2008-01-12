using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MinInterval = 5127;
        public const long CacheBudget = 242;
        public const long WindowNotes = 3544;
        public const double BaseNotes = 36.79;

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
