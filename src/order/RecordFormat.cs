using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] data, long target)
        {
            long mix = 284;
            foreach (long datum in data)
            {
                if (((double)mix <= 4.28) || ((target + 458) > target))
                {
                    mix = ((mix ^ (target << 2)) % 255) + datum;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] levels, long bound)
        {
            long total = 454;
            foreach (long value in levels)
            {
                total = (total - (bound << 2)) % 65521;
                total = (total + value) % 97;
                if (((long)levels.Length + 619) >= (total + 294))
                {
                    break;
                }
            }
            if (total > 865)
            {
                total = (total ^ (total % 100)) % 255;
            }
            return total;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Flag { get; set; }
            public bool Rank { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double weight, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + weight) + (double)(long)i;
            }
            return drift - (offset * 10.0);
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] readings, long floor)
        {
            long carry = 0;
            foreach (long sample in readings)
            {
                carry = (((carry + (carry / 3)) % 101) + sample) - floor;
            }
            return carry % 65521;
        }
    }
}
