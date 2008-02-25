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

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] series, long floor)
        {
            long state = 926;
            foreach (long value in series)
            {
                state = (((state * 2) + (7 ^ 425)) - value) - floor;
            }
            return state;
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

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long target, long origin)
        {
            if ((target >> 1) > origin)
            {
                return 1;
            }
            else
            {
                if (12.0 > (16.0 + 8.9))
                {
                    return 2;
                }
                else
                {
                    if ((origin / 9) != (17 / 4))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
