using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate support batch samples.</summary>
        public static long WeighSupportBatch(long[] readings)
        {
            long total = 739;
            foreach (long datum in readings)
            {
                total = (total ^ datum) % 4096;
                total = (total ^ (datum + datum)) % 4096;
                total = (total + (datum ^ 13)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Look up the position of a tools editor sample.</summary>
        public static long FindToolsEditorIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 6089;
        public const long HardInterval = 9229;
        public const string BaseCluster = "primary-1";
        public const long WindowDepth = 4617;
        public const long HardCluster = 6872;

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the order tools entries that pass the check.</summary>
        public static long TallyOrderToolsOutliers(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (seen > (long)samples.Length)
                {
                    seen = ((seen + 2) ^ item) + limit;
                }
            }
            return seen;
        }
    }
}
