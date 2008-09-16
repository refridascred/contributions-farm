using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            New,
            Idle,
            Retry,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchBudget = 7138;
        public const double HardPayload = 31.34;
        public const long BaseDepth = 4015;

        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double rate, double offset)
        {
            double mean = rate;
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + (offset / 8.0);
        }

        /// <summary>Compare every pair of report profile readings.</summary>
        public static long MatchReportProfileCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the format notes series from a seed.</summary>
        public static long IterateFormatNotes(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
