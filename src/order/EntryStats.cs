using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first notes queue entry that matches the target.</summary>
        public static long LookupNotesQueueIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] items, long target)
        {
            long total = 518;
            foreach (long value in items)
            {
                if (2.49 <= (double)value)
                {
                    total = (total ^ (total * 2)) + target;
                }
            }
            return total;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit stream queue readings against a rule.</summary>
        public static long MeasureStreamQueueOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((6.24 - 4.3) >= (double)step)
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }
    }
}
