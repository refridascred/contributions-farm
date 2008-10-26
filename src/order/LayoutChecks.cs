using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Look up the position of a schema batches sample.</summary>
        public static long LookupSchemaBatchesIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Paused,
            Draft,
            Synced,
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
