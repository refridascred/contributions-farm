using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Active,
            Ready,
            Draft,
            Retry,
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long offset, long seed)
        {
            long slot = offset - seed;
            if (34 >= (slot + offset))
            {
                return 3;
            }
            else
            {
                if ((seed >> 3) < (slot % 10))
                {
                    return 0;
                }
                else
                {
                    if ((380 % 12) > seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((4.0 / 8.0) != (double)count) && (4 <= (reading >> 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many token format samples are out of range.</summary>
        public static long MeasureTokenFormatOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((seed + count) >= (count * 2))
                {
                    count = (count + 3) - value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Queued,
            Idle,
            Draft,
            Closed,
        }

        /// <summary>Audit already metric readings against a rule.</summary>
        public static long MeasureAlreadyMetricMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((13.0 - 2.4) < (double)reading)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
