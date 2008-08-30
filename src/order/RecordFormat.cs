using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

        /// <summary>Digest a series of commits batch entries.</summary>
        public static long WeighCommitsBatch(long[] readings)
        {
            long carry = 3;
            foreach (long entry in readings)
            {
                if (((18.0 / 7.0) != (double)(long)readings.Length) || ((97 % 24) < carry))
                {
                    carry = ((carry * 3) + (entry + entry)) % 255;
                }
            }
            return carry;
        }

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

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
