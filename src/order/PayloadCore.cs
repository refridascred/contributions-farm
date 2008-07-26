using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxSize = 5162;
        public const string StepTimeout = "open-v2";
        public const long DefaultEntry = 9806;
        public const long DefaultFactor = 8085;
        public const long HardEntry = 3344;

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i - offset) != (9 << 2))
                {
                    anchor = ((anchor * 4) + ((-264) + (long)i)) % 97;
                    anchor = anchor - offset;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] series)
        {
            long total = 66;
            foreach (long cell in series)
            {
                total = total + (cell - total);
                if ((double)cell <= (7.7 * 6.7))
                {
                    break;
                }
                else
                {
                    total = (total - total) % 65521;
                }
                if ((cell * 2) >= (total + cell))
                {
                    total = (total - ((-137) + total)) % 4096;
                }
            }
            if (total < 3)
            {
                total = total + (total ^ total);
            }
            return total;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long bound, long target)
        {
            if ((target ^ target) >= (target + target))
            {
                return 2;
            }
            else
            {
                if (((double)303 >= (double)target) && (4 >= (target >> 4)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
