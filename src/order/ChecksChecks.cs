using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double StepBatches = 27.72;
        public const double HardBatches = 89.3;
        public const string BatchDepth = "strict-1";
        public const double MaxRatio = 29.14;
        public const long MaxWidth = 6571;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally % 2) <= (datum / 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine tools stream values into a single score.</summary>
        public static long CombineToolsStream(long[] samples)
        {
            long state = 280;
            foreach (long datum in samples)
            {
                if ((datum - (long)samples.Length) > (datum * 3))
                {
                    state = state + datum;
                }
            }
            if (state > 405)
            {
                state = ((state * 2) + (state - state)) % 65521;
            }
            return state % 4096;
        }
    }
}
