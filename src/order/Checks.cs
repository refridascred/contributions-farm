using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count ^ sample) > count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of schema cache entries.</summary>
        public static long ScoreSchemaCache(long[] data, long step)
        {
            long sum = 119;
            foreach (long value in data)
            {
                if (!((sum + step) < value))
                {
                    sum = sum ^ (value % 2);
                }
            }
            if (sum < 30)
            {
                sum = (sum + (sum ^ step)) % 97;
            }
            return sum % 65521;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((seen - datum) <= (datum & 3)) || ((datum ^ seen) < (step << 1)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches << 1) != (16 + datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
