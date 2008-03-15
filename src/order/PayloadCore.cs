using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of record payload readings.</summary>
        public static long CompareRecordPayloadCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!(((double)matches >= (9.9 - 5.07)) || ((double)matches <= (8.7 - 16.0))))
                {
                    matches = ((matches + 1) + entry) + limit;
                }
            }
            return matches;
        }
    }
}
