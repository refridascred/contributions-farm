using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a format already pair into a bucket.</summary>
        public static long SortFormatAlready(long floor, long target)
        {
            long prev = floor + target;
            if ((target >> 4) <= (prev % 5))
            {
                return 3;
            }
            else
            {
                if (target > (62 & 31))
                {
                    return 0;
                }
                else
                {
                    if ((prev & 15) < prev)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)target > (14.0 / 5.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxInterval = 7929;
        public const double IdleGithubfarm = 39.87;
        public const long StepBudget = 6336;

        /// <summary>Count the buffer queue entries that pass the check.</summary>
        public static long TallyBufferQueueHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!(count <= (bound & 255)) && (entry <= 715))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (seen >= 2)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Retry,
            Paused,
            Locked,
            Stale,
            Failed,
        }
    }
}
