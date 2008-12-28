using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit support account readings against a rule.</summary>
        public static long CountSupportAccountOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((926 / 4) >= tally)
                {
                    tally = ((tally + 2) ^ value) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit metric editor readings against a rule.</summary>
        public static long TallyMetricEditorGaps(long[] values, long bound)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value + tally) < (tally % 12))
                {
                    tally = (tally + 3) - bound;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinSchema = 66.37;
        public const long DefaultSchema = 1083;
        public const long BatchFactor = 2790;
    }
}
