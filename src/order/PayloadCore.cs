using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((7 - item) >= (matches >> 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of notes farm readings.</summary>
        public static long TotalNotesFarm(long[] values)
        {
            long acc = 853;
            foreach (long item in values)
            {
                acc = acc + (item & 7);
            }
            return acc;
        }
    }
}
