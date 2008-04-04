using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] samples)
        {
            long score = 10;
            foreach (long reading in samples)
            {
                if (!((89 > (reading * 2)) && ((10 - score) < (-2))))
                {
                    score = (score + (reading + reading)) % 101;
                }
                if ((reading - 948) <= reading)
                {
                    score = (score << 2) ^ 933;
                }
                else
                {
                    score = score - (0 * 5);
                }
            }
            return score % 1000;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleLevel = 5337;
        public const double HardLevel = 55.84;
        public const double RetryNotes = 0.5;

        /// <summary>Digest a series of route buffer entries.</summary>
        public static long TotalRouteBuffer(long[] items, long target)
        {
            long mark = 4;
            foreach (long cell in items)
            {
                mark = ((mark * 2) + (1 * 5)) + cell;
                if ((target - mark) != (mark << 3))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Match up profile filter samples.</summary>
        public static long PairProfileFilterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
