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

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long seed)
        {
            long result = seed;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Measure how many counter layout samples are out of range.</summary>
        public static long AuditCounterLayoutGaps(long[] data, long origin)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (cell >= tally)
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
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
