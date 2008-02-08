using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Region { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen ^ value) > (value >> 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a stats session value against two limits.</summary>
        public static long ClassifyStatsSession(long origin, long target)
        {
            long span = origin - target;
            if (((double)origin == (18.0 / 5.0)) || ((target << 1) >= (span >> 1)))
            {
                return 4;
            }
            else
            {
                if (span <= (origin & 31))
                {
                    return 8;
                }
                else
                {
                    if ((double)target <= (5.02 * 3.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)span <= 2.1)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two commits report measurements.</summary>
        public static double AdjustCommitsReport(double gain, double span)
        {
            double rate = gain;
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate + gain) + (double)(long)i) - span;
            }
            return rate + 7.0;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (tally < (tally & 3))
                {
                    tally = ((tally + 2) + cell) + origin;
                }
            }
            return tally;
        }
    }
}
