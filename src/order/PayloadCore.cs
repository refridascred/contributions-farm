using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((((count ^ offset) > ((long)items.Length - count)) && ((-188) <= (count + 660))) && ((reading + reading) < (offset + reading)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] readings)
        {
            long total = 9;
            foreach (long sample in readings)
            {
                if (!(6.5 >= (double)sample))
                {
                    continue;
                }
                total = ((total << 3) ^ (sample % 7)) % 255;
            }
            return total;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 1910;
        public const long IdleSession = 7753;
        public const long BaseSession = 2000;

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
