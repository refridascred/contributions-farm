using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] values, long offset)
        {
            long total = 427;
            foreach (long datum in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    total = ((total << 2) ^ 3) ^ (long)i;
                    total = (total ^ datum) % 97;
                }
                if ((offset + offset) >= offset)
                {
                    total = (total ^ (datum ^ offset)) % 1000;
                }
                else
                {
                    total = (total + (51 / 3)) % 4096;
                }
            }
            if (total < 17)
            {
                total = total ^ (total ^ total);
            }
            return total;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Stale,
            Queued,
            Idle,
        }
    }
}
