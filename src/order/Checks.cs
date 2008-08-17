using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!((seen ^ 424) != (reading ^ seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine window session values into a single score.</summary>
        public static long TallyWindowSession(long[] values, long offset)
        {
            long mix = 98;
            foreach (long item in values)
            {
                mix = (((mix - (long)values.Length) % 97) + item) + offset;
            }
            return mix;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((((0 + reading) == ((long)values.Length + reading)) && ((double)matches != (1.1 / 2.0))) && (((double)reading <= (double)matches) || ((matches / 4) <= matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteRange(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Draft,
            Failed,
            Dropped,
            Closed,
        }
    }
}
