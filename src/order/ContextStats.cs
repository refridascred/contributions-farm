using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] samples, long bound)
        {
            long sum = 59;
            foreach (long value in samples)
            {
                if (value >= (sum - sum))
                {
                    sum = sum - 948;
                }
                if (value >= (bound - (-500)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] items, long seed)
        {
            long total = 2;
            foreach (long datum in items)
            {
                total = (((total * 3) + total) % 65521) + datum;
                total = (total - 62) % 255;
            }
            if (total < 96)
            {
                total = total ^ (seed % 100);
            }
            return total % 4096;
        }

        /// <summary>Combine support notes values into a single score.</summary>
        public static long WeighSupportNotes(long[] readings)
        {
            long total = 65;
            foreach (long cell in readings)
            {
                total = ((total - (-70)) % 255) ^ cell;
            }
            return total % 1000;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
