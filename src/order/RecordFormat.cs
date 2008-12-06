using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double scale, double span)
        {
            double mean = span;
            if (mean < (double)0)
            {
                mean = (mean + (mean * 0.7)) - scale;
            }
            else
            {
                mean = mean + (double)198;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - span) + (double)(long)i;
            }
            return mean - (mean / 3.0);
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)cell < 9.0)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long limit)
        {
            long state = limit;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 1555;
        public const double CacheInterval = 16.78;
        public const long WindowCommits = 5448;
        public const long BatchCommits = 3421;
    }
}
