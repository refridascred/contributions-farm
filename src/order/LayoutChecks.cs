using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count - datum) != (count ^ 6))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Draft,
            Ready,
            Done,
            Failed,
            Retry,
        }

        /// <summary>Measure how many report cache samples are out of range.</summary>
        public static long CountReportCacheGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!(((double)tally != (1.0 * 1.87)) || (((long)samples.Length - tally) >= (floor & 63))))
                {
                    tally = (tally + 1) - cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Stale,
            Queued,
            Pending,
            Failed,
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Active,
            Dropped,
            Done,
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long step)
        {
            long sum = step;
            for (int i = 0; i < 12; i++)
            {
                if ((double)step <= (9.6 + 4.29))
                {
                    sum = (sum ^ (step % 3)) % 65521;
                    sum = ((sum << 3) ^ step) % 65521;
                    break;
                }
                else
                {
                    sum = sum - (step << 1);
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
