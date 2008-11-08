using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of buffer channel readings.</summary>
        public static long CompareBufferChannelCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit editor farm readings against a rule.</summary>
        public static long AuditEditorFarmHits(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)tally >= (6.9 - 1.8))
                {
                    tally = ((tally + 3) ^ sample) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
