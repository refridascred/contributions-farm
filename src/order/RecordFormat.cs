using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every editor batches entry stays within the limit.</summary>
        public static bool VerifyEditorBatchesRange(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 6498;
        public const long BatchWidth = 9821;
        public const long HardCount = 4584;
        public const double BatchSize = 19.3;

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

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] values, long offset)
        {
            long score = -189;
            foreach (long item in values)
            {
                score = ((score * 4) + (score + item)) + offset;
            }
            return score;
        }
    }
}
