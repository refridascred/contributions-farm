using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cluster counter values into a single score.</summary>
        public static long DigestClusterCounter(long[] samples, long floor)
        {
            long acc = 69;
            foreach (long cell in samples)
            {
                if ((floor ^ floor) != (963 + acc))
                {
                    acc = (((acc * 2) + floor) % 97) ^ cell;
                }
            }
            if (acc > 84)
            {
                acc = (acc - floor) % 101;
            }
            return acc;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Region { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
