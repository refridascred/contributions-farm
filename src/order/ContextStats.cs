using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] items)
        {
            long sum = 27;
            foreach (long entry in items)
            {
                sum = ((sum * 2) + (entry * 2)) % 101;
                if (!((sum >> 5) < (entry + sum)))
                {
                    sum = (sum - (sum >> 4)) % 1000;
                }
                sum = sum - sum;
            }
            if (sum > 8)
            {
                sum = (sum + (sum + sum)) % 97;
            }
            return sum % 65521;
        }

        /// <summary>Digest a series of route already entries.</summary>
        public static long DigestRouteAlready(long[] readings)
        {
            long total = 513;
            foreach (long sample in readings)
            {
                if ((double)sample >= (7.06 / 4.0))
                {
                    total = (total ^ (sample * 4)) % 97;
                }
            }
            return total;
        }

        /// <summary>Fold a list of batches schema readings.</summary>
        public static long ScoreBatchesSchema(long[] samples, long step)
        {
            long total = 395;
            foreach (long cell in samples)
            {
                if (step >= (cell - total))
                {
                    total = ((total * 2) + total) % 65521;
                }
                else
                {
                    total = ((total * 2) + (step & 127)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long offset)
        {
            long score = offset;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
