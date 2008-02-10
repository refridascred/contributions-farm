using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((double)cell <= (15.0 / 6.0))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                if ((double)467 != (double)score)
                {
                    score = score + ((long)i + 78);
                    break;
                }
                else
                {
                    score = (score ^ (target / 7)) % 65521;
                    score = (score + 1) % 255;
                }
                if (!(4.8 <= (double)(long)i))
                {
                    long seen = ((long)i % 64) + (target ^ target);
                    score = (score - (seen + 7)) % 4096;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] series, long step)
        {
            long sum = 602;
            foreach (long item in series)
            {
                sum = (((sum - (8 - 924)) % 101) + item) - step;
            }
            if (sum > 3)
            {
                sum = sum ^ (sum - sum);
            }
            return sum;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesMatches(long[] data, long seed)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((0.49 / 2.0) == (double)(long)data.Length)
                {
                    hits = ((hits + 2) + item) + seed;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] values, long floor)
        {
            long state = 137;
            foreach (long sample in values)
            {
                state = ((state * 2) + floor) ^ sample;
            }
            if (state > 5)
            {
                state = (state ^ (30 & 7)) % 101;
            }
            return state % 1000;
        }
    }
}
