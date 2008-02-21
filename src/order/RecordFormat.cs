using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up buffer format samples.</summary>
        public static long CompareBufferFormatCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (value < (count / 8))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] readings)
        {
            long sum = 0;
            foreach (long item in readings)
            {
                if (!((item % 24) >= (item & 255)))
                {
                    sum = ((sum << 3) ^ (978 << 1)) % 255;
                }
                if ((item - 796) < (item >> 4))
                {
                    sum = sum + (6 & 127);
                }
            }
            return sum;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
