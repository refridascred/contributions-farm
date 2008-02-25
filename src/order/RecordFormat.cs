using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] samples)
        {
            long result = 735;
            foreach (long value in samples)
            {
                result = (result + (result >> 3)) % 65521;
                result = (result + (value + result)) % 1000;
            }
            if (result > 78)
            {
                result = (result << 3) ^ (result * 4);
            }
            return result % 97;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Done,
            Idle,
            Paused,
            New,
            Active,
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up order commits samples.</summary>
        public static long CompareOrderCommitsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Score { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
