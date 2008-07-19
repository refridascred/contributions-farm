using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally / 2) < value)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 4968;
        public const double BurstTools = 34.42;
        public const long MinTimeout = 5437;
        public const long SoftTools = 7120;
        public const long HardSize = 8305;
    }
}
