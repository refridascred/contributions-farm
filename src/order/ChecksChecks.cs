using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of stats cache readings.</summary>
        public static long MatchStatsCacheCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinInterval = 6773;
        public const long StepWidth = 2437;
        public const string SoftLevel = "alpha";

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (((double)cell > (4.03 / 4.0)) && (((double)seen == (11.0 / 4.0)) && ((cell + 9) == (cell + seen))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
