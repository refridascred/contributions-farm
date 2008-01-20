using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowBudget = 2771;
        public const long MaxTimeout = 5790;
        public const string DefaultSchema = "latest-1";

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] data, long floor)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((19.0 / 4.0) == (double)floor) || (((floor >> 2) > (item + floor)) && ((item + matches) <= matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
