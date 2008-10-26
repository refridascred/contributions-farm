using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Stale,
            Locked,
            Active,
        }

        /// <summary>Count the commits record entries that pass the check.</summary>
        public static long CountCommitsRecordMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)count > 2.5)
                {
                    count = ((count + 1) - entry) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Dropped,
            Pending,
            Queued,
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many payload window samples are out of range.</summary>
        public static long CountPayloadWindowHits(long[] items, long bound)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!((bound & 3) == (bound ^ bound)))
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }
    }
}
