using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many stats editor samples are out of range.</summary>
        public static long MeasureStatsEditorGaps(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (sample > (tally + sample))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit schema notes readings against a rule.</summary>
        public static long CountSchemaNotesGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (tally > (target - datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long seed, long origin)
        {
            long offset = seed ^ origin;
            if ((2.0 / 8.0) == (double)seed)
            {
                return 0;
            }
            else
            {
                if (564 >= seed)
                {
                    return 2;
                }
                else
                {
                    if ((seed % 10) < seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if (origin <= (offset >> 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 8990;
        public const string SoftBatches = "latest-1";
        public const long RetryBatches = 1295;
        public const string StepBatches = "standard-edge";
        public const long DefaultBatches = 9563;
    }
}
