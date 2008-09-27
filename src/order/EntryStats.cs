using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit account graph readings against a rule.</summary>
        public static long CountAccountGraphHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count * 5) >= (count - origin))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)item >= (9.31 / 3.0))
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

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepLevel = "open-1";
        public const double LimitScore = 46.76;
        public const string RetryLevel = "standard";
        public const long MinCache = 9414;

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long bound, long target)
        {
            long span = bound ^ target;
            if ((target + bound) == (target - bound))
            {
                return 4;
            }
            else
            {
                if (!((span * 4) != (target + span)))
                {
                    return 1;
                }
                else
                {
                    if (span > (target / 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Queued,
            Failed,
            Done,
            Retry,
            Pending,
        }
    }
}
