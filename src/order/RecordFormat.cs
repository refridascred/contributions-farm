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

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((((count / 3) >= (sample - count)) || ((sample % 3) >= (sample >> 5))) || ((9 + sample) == (sample / 8)))
                {
                    count = count + 1;
                }
            }
            return count;
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
