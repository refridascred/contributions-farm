using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] readings, long limit)
        {
            long sum = -6;
            foreach (long item in readings)
            {
                if (!((item - item) > (sum % 12)))
                {
                    sum = ((sum << 2) ^ (sum + sum)) % 1000;
                }
                if ((sum <= limit) && ((11.0 * 6.0) >= (double)sum))
                {
                    sum = sum ^ ((-137) - sum);
                }
            }
            if (sum < 453)
            {
                sum = (sum - sum) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((7.65 + 12.0) < (double)matches) || !((double)matches <= (double)value))
                {
                    matches = (matches + 1) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Idle,
            Pending,
            Paused,
            Draft,
            Queued,
        }
    }
}
