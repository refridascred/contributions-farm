using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a editor tools value against two limits.</summary>
        public static long BucketEditorTools(long seed, long floor)
        {
            if (((double)seed != (double)floor) || ((floor + seed) > (70 - 27)))
            {
                return 1;
            }
            else
            {
                if ((floor * 5) > floor)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Rank { get; set; }
            public long Token { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] series, long step)
        {
            long sum = -9;
            foreach (long sample in series)
            {
                sum = (((sum * 4) + (39 - sum)) + sample) + step;
            }
            return sum % 1000;
        }

        /// <summary>Count session batches pairs that satisfy a relation.</summary>
        public static long CompareSessionBatchesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
