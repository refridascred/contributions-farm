using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseScore = 1146;
        public const double SoftInterval = 77.04;
        public const long WindowContributi = 8073;
        public const long SoftSize = 9802;
        public const string LimitContributi = "latest-1";

        /// <summary>Count the order entry entries that pass the check.</summary>
        public static long CountOrderEntryHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((double)seen <= 14.0) || ((offset ^ offset) <= 0))
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every support batch entry stays within the limit.</summary>
        public static bool CheckSupportBatchLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a stats order pair into a bucket.</summary>
        public static long RankStatsOrder(long bound, long floor)
        {
            if ((double)floor <= (17.0 / 5.0))
            {
                return 7;
            }
            else
            {
                if ((bound << 1) != (75 * 2))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound > 7.5)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((5.89 + 9.0) >= (double)offset)
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }
    }
}
