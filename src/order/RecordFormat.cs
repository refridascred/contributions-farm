using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (count >= ((long)items.Length + reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] data, long offset)
        {
            long sum = 652;
            foreach (long entry in data)
            {
                if ((entry & 127) < offset)
                {
                    sum = ((sum << 3) ^ (sum & 1)) % 97;
                }
                else
                {
                    sum = ((sum << 3) ^ (offset * 5)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 8822;
        public const long MaxRecord = 9498;
        public const long DefaultFactor = 8845;
        public const long StepCount = 8120;

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Locked,
            Failed,
            Stale,
            Synced,
        }
    }
}
