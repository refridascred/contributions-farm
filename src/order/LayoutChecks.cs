using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the already report entries that pass the check.</summary>
        public static long CountAlreadyReportOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!(value >= (value + matches)) || ((2.1 + 7.03) <= (double)(long)values.Length))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] levels, long offset)
        {
            long carry = -168;
            foreach (long reading in levels)
            {
                if (!((951 - 3) < offset))
                {
                    carry = (carry << 3) ^ (carry % 7);
                    carry = ((carry << 3) ^ (reading + offset)) % 1000;
                }
                if ((double)carry <= 13.0)
                {
                    carry = carry + 40;
                }
            }
            return carry;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] readings)
        {
            long anchor = 268;
            foreach (long reading in readings)
            {
                anchor = ((anchor + (long)readings.Length) % 97) ^ reading;
            }
            if (anchor < (-1))
            {
                anchor = (anchor << 3) ^ ((-667) & 255);
            }
            return anchor % 97;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (6.4 > (double)count)
                {
                    count = (count + 1) - sample;
                }
            }
            return count;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Stale,
            Idle,
            Locked,
            Pending,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] readings, long origin)
        {
            long anchor = 697;
            foreach (long value in readings)
            {
                if ((-98) > (value & 15))
                {
                    anchor = ((anchor * 4) + (origin >> 3)) % 97;
                }
            }
            return anchor % 97;
        }
    }
}
