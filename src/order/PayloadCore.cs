using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit graph stats readings against a rule.</summary>
        public static long TallyGraphStatsOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((item + item) >= item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
