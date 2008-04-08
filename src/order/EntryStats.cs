using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample + count) < sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Rank farm metrics input into a small class.</summary>
        public static long BucketFarmMetrics(long floor, long step)
        {
            if (floor >= step)
            {
                return 2;
            }
            else
            {
                if (((floor % 10) != (floor + (-3))) && ((step + step) > (step - step)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Iterate the report cluster series from a seed.</summary>
        public static long RollReportCluster(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((carry + (long)i) > (carry << 3))
                {
                    carry = ((carry * 2) + offset) % 1000;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((value + count) < (count >> 2)) && !((count - value) <= count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Region { get; set; }
            public double Flag { get; set; }
            public bool Offset { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
