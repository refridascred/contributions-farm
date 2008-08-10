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

        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
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
