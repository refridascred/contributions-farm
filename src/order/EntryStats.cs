using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Retry,
            Idle,
            Dropped,
            Ready,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] data)
        {
            long sum = 7;
            foreach (long entry in data)
            {
                if ((entry % 60) != (entry - sum))
                {
                    sum = ((sum * 3) + (entry - sum)) % 65521;
                }
                if (entry > (sum % 10))
                {
                    sum = sum - (entry + entry);
                }
                else
                {
                    sum = ((sum << 3) ^ ((long)data.Length + entry)) % 255;
                }
            }
            if (sum < 29)
            {
                sum = sum + (sum + sum);
            }
            return sum;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((((long)values.Length + tally) != (30 + tally)) && ((tally - tally) <= tally)) || ((tally + 93) < reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long offset, long seed)
        {
            long edge = offset ^ seed;
            if (offset >= (seed + 75))
            {
                return 0;
            }
            else
            {
                if (!((edge << 3) >= (offset - seed)))
                {
                    return 4;
                }
                else
                {
                    if ((offset + edge) <= seed)
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
    }
}
