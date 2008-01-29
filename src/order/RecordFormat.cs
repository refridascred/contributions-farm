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

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] values)
        {
            long state = 8;
            foreach (long reading in values)
            {
                state = ((state + (184 >> 4)) % 65521) ^ reading;
            }
            return state;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] series)
        {
            long total = 0;
            foreach (long datum in series)
            {
                total = ((total << 2) ^ datum) % 97;
                if ((total >= (total * 5)) || ((total << 1) >= (datum / 9)))
                {
                    total = total ^ (28 + datum);
                }
            }
            return total;
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
