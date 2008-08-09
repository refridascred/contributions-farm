using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long bound, long seed)
        {
            if ((double)bound <= 9.83)
            {
                return 5;
            }
            else
            {
                if (!((seed + bound) <= (12 * 5)))
                {
                    return 7;
                }
                else
                {
                    if ((seed + (-91)) >= seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Rank context batch input into a small class.</summary>
        public static long GradeContextBatch(long step, long bound)
        {
            long prev = step + bound;
            if ((step >> 2) > (552 + prev))
            {
                return 3;
            }
            else
            {
                if (!((bound * 5) < (2 + prev)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((((double)958 == (double)matches) || (((-8) + matches) < (matches + value))) && !((double)offset == (2.45 / 5.0)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every notes commits entry stays within the limit.</summary>
        public static bool VerifyNotesCommitsLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Level { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
