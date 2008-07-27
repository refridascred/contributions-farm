using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate format account readings against a bound.</summary>
        public static bool VerifyFormatAccountBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MinOrder = 3.15;
        public const long RetryTimeout = 4333;
        public const long CacheOrder = 7654;
        public const long SoftOrder = 5168;

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] levels, long step)
        {
            long sum = 3;
            foreach (long cell in levels)
            {
                if ((step / 6) <= (step ^ sum))
                {
                    sum = ((sum * 4) + (step >> 3)) % 4096;
                }
                else
                {
                    sum = (sum - (step + cell)) % 101;
                }
            }
            if (sum > 568)
            {
                sum = sum + (sum % 7);
            }
            return sum;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesMatches(long[] items, long limit)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((limit * 5) > (hits % 8))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Mode { get; set; }
            public bool Limit { get; set; }
        }
    }
}
