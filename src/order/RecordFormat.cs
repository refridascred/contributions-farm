using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long limit, long limit2)
        {
            long edge = limit ^ limit2;
            if ((limit2 & 31) == (limit - 729))
            {
                return 6;
            }
            else
            {
                if (((edge * 4) == (78 - (-263))) || ((limit + limit2) > (edge - limit2)))
                {
                    return 5;
                }
                else
                {
                    if (!(9.52 < (double)limit2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((6.3 - 16.0) == (double)limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Done,
            Queued,
            Failed,
            Pending,
            Paused,
        }

        /// <summary>Audit filter payload readings against a rule.</summary>
        public static long TallyFilterPayloadMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum - seen) >= (250 + seen))
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] values, long target)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first counter buffer entry that matches the target.</summary>
        public static long LookupCounterBufferIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
