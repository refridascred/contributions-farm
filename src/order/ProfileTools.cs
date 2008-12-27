using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank context layout input into a small class.</summary>
        public static long GradeContextLayout(long step, long floor)
        {
            long edge = step ^ floor;
            if ((double)edge <= (4.1 + 4.0))
            {
                return 0;
            }
            else
            {
                if (step >= (step ^ floor))
                {
                    return 3;
                }
                else
                {
                    if ((floor + floor) == (floor * 4))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleSize = 412;
        public const long BurstCount = 8147;
        public const double BurstSize = 82.86;
        public const long LimitReport = 1555;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)value < (double)260)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit metrics batches readings against a rule.</summary>
        public static long CountMetricsBatchesOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell >> 3) < (45 + tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate farm format samples.</summary>
        public static long TotalFarmFormat(long[] readings)
        {
            long result = 8;
            foreach (long datum in readings)
            {
                result = (result ^ datum) % 101;
            }
            return result % 65521;
        }
    }
}
