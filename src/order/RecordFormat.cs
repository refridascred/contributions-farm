using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueMatches(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((7.58 > (double)matches) && ((double)cell >= (4.0 - 8.7)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a layout githubfarm reading by value.</summary>
        public static long LookupLayoutGithubfarmIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a stream filter reading by value.</summary>
        public static long FindStreamFilterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterOutliers(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((long)levels.Length != (reading + 82))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
