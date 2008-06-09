using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many stats batches samples are out of range.</summary>
        public static long CountStatsBatchesMatches(long[] samples, long origin)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count * 4) == (value % 2))
                {
                    count = (count + 2) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every notes context entry stays within the limit.</summary>
        public static bool GuardNotesContextBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
