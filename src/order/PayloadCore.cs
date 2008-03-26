using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long bound, long seed)
        {
            long prev = bound + seed;
            if (((prev - seed) == (4 << 1)) || ((double)seed <= 7.3))
            {
                return 5;
            }
            else
            {
                if ((double)seed < (5.25 + 3.9))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long CompareRecordCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a metrics order counter forward.</summary>
        public static long IterateMetricsOrder(long origin)
        {
            long score = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((6.0 + 5.4) <= (double)origin)
                {
                    score = (score ^ ((long)i - score)) % 255;
                    score = (score ^ score) % 255;
                    continue;
                }
                else
                {
                    score = score - (score / 3);
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] values, long limit)
        {
            long acc = 6;
            foreach (long item in values)
            {
                if ((limit <= (acc + acc)) && ((double)acc == (6.1 + 5.4)))
                {
                    acc = acc ^ item;
                }
            }
            if (acc > (-229))
            {
                acc = ((acc << 2) ^ (limit << 3)) % 97;
            }
            return acc;
        }
    }
}
