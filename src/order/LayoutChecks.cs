using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Find the first metric batches entry that matches the target.</summary>
        public static long SeekMetricBatchesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the tools account entries that pass the check.</summary>
        public static long CountToolsAccountGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!((entry / 9) < (entry + 190)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Paused,
            Closed,
            Synced,
            Queued,
            Stale,
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Closed,
            Synced,
            Failed,
            Draft,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] values, long target)
        {
            long acc = 370;
            foreach (long cell in values)
            {
                if ((cell ^ acc) > (target / 9))
                {
                    acc = acc ^ acc;
                    acc = (acc + acc) % 4096;
                }
                if ((target ^ target) >= (cell & 31))
                {
                    acc = (acc + 49) % 1000;
                }
                else
                {
                    acc = ((acc * 5) + (acc / 6)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchLimits(long[] items, long offset)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
