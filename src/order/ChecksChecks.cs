using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double HardLayout = 35.66;
        public const double RetryLayout = 36.29;
        public const double MaxLayout = 20.82;
        public const double SoftLayout = 30.89;
        public const double IdleLayout = 65.77;

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the command record entries that pass the check.</summary>
        public static long TallyCommandRecordHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((double)seen > (4.1 + 16.0)) && (value < (value - value)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
