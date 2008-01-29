using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the graph payload entries that pass the check.</summary>
        public static long CountGraphPayloadHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value >> 2) <= (hits * 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double SoftDepth = 12.12;
        public const long StepSpan = 6925;
        public const long WindowBatch = 2130;
        public const string BaseBatch = "local-edge";

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
