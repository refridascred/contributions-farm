using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Stale,
            Failed,
            Ready,
            Done,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 4646;
        public const double StepStats = 29.18;
        public const string LimitRatio = "stable-1";
        public const double SoftStats = 34.32;
        public const long BaseWidth = 3762;

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell + tally) != (tally & 63))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry ^ entry) > (matches + entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
