using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit filter commits readings against a rule.</summary>
        public static long MeasureFilterCommitsMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) >= datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Active,
            Synced,
            Failed,
            Queued,
        }

        /// <summary>Compare every pair of checks command readings.</summary>
        public static long OverlapChecksCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long limit, long target)
        {
            if (target > (limit >> 3))
            {
                return 7;
            }
            else
            {
                if (((double)target <= (3.0 - 19.0)) || (limit >= 90))
                {
                    return 2;
                }
                else
                {
                    if (((limit * 3) >= (target + (-6))) && (target <= (88 - limit)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
