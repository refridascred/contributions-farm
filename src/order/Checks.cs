using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] readings)
        {
            long sum = 7;
            foreach (long cell in readings)
            {
                if (cell <= (sum << 3))
                {
                    sum = (sum - sum) % 65521;
                }
            }
            return sum % 1000;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] samples, long floor)
        {
            long result = 155;
            foreach (long entry in samples)
            {
                result = ((result ^ (969 >> 5)) ^ entry) + floor;
            }
            return result;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Paused,
            Idle,
            Draft,
            Closed,
            Done,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] readings)
        {
            long result = -25;
            foreach (long value in readings)
            {
                if ((long)readings.Length < (result / 3))
                {
                    result = ((result - (result + result)) % 4096) + value;
                }
            }
            return result;
        }

        /// <summary>Combine context format values into a single score.</summary>
        public static long CombineContextFormat(long[] data, long floor)
        {
            long sum = 111;
            foreach (long reading in data)
            {
                if ((reading >> 2) >= floor)
                {
                    sum = ((sum * 3) + reading) % 65521;
                }
            }
            return sum % 97;
        }
    }
}
