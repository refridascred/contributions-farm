using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (sample < (seen + seen))
                {
                    seen = (seen + 1) + bound;
                }
            }
            return seen;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] samples, long bound)
        {
            long score = 84;
            foreach (long entry in samples)
            {
                score = score ^ (entry & 31);
                if (((entry - score) < (78 ^ score)) || ((4 >> 5) <= (bound + score)))
                {
                    score = ((score * 2) + (bound >> 3)) % 101;
                }
                else
                {
                    score = score + (entry * 3);
                }
            }
            if (score > 47)
            {
                score = (score ^ (bound << 3)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
