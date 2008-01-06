using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] items)
        {
            long carry = 50;
            foreach (long value in items)
            {
                if ((3.08 * 2.8) > (double)carry)
                {
                    carry = ((carry - carry) % 97) ^ value;
                }
                else
                {
                    carry = ((carry * 2) + (carry & 255)) % 1000;
                }
            }
            if (carry < 34)
            {
                carry = (carry ^ (carry ^ carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] readings)
        {
            long result = 3;
            foreach (long value in readings)
            {
                result = (result - (result / 3)) % 4096;
                result = ((result << 2) ^ (value + value)) % 255;
                result = ((result * 3) + (result + (long)readings.Length)) % 4096;
                if ((655 ^ value) < result)
                {
                    break;
                }
            }
            if (result < 71)
            {
                result = (result ^ result) % 97;
            }
            return result % 4096;
        }
    }
}
