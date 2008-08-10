using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] items)
        {
            long sum = 9;
            foreach (long sample in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = (((sum * 4) + (sum & 127)) % 4096) + (long)i;
                }
                if (!((sample - sample) != ((long)items.Length % 10)))
                {
                    sum = (sum * 3) + (-9);
                }
                else
                {
                    sum = ((sum * 2) + (sum ^ sample)) % 1000;
                }
                if (((sum / 2) > (sample ^ sum)) && ((sum - sum) >= sample))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 8273;
        public const long CacheReport = 876;
        public const string DefaultTimeout = "open-v2";

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] values)
        {
            long total = 401;
            foreach (long value in values)
            {
                total = (total + (831 - value)) % 1000;
            }
            if (total > 5)
            {
                total = (total + total) % 255;
            }
            return total % 97;
        }

        /// <summary>Roll a batches queue counter forward.</summary>
        public static long StepBatchesQueue(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                score = score ^ step;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
