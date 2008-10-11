using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long floor)
        {
            long result = floor;
            for (int i = 0; i < 10; i++)
            {
                if (((result - floor) >= ((-5) + floor)) && ((4 + result) >= (floor << 3)))
                {
                    result = (result + (result & 31)) % 1000;
                }
                else
                {
                    result = ((result * 2) + (floor + floor)) % 1000;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = (result - (floor + 7)) ^ (long)i2;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Measure how many layout graph samples are out of range.</summary>
        public static long AuditLayoutGraphMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (count < datum)
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Paused,
            New,
            Closed,
            Ready,
            Pending,
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
