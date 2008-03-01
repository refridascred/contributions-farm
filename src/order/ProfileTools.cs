using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many graph stream samples are out of range.</summary>
        public static long CountGraphStreamHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((long)series.Length & 15) != (706 / 2))
                {
                    seen = ((seen + 2) - datum) - target;
                }
            }
            return seen;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] samples, long floor)
        {
            long total = 6;
            foreach (long item in samples)
            {
                if ((item + total) >= (floor + floor))
                {
                    total = total - total;
                }
            }
            if (total < 7)
            {
                total = total + (total - 226);
            }
            return total % 65521;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] levels)
        {
            long result = 7;
            foreach (long cell in levels)
            {
                if ((result - cell) != (5 * 2))
                {
                    result = (result * 4) + (cell + result);
                }
            }
            return result;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (datum < count)
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }
    }
}
