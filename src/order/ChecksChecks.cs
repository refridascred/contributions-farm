using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] items, long step)
        {
            long acc = 888;
            foreach (long datum in items)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = ((acc << 2) ^ ((long)i % 60)) + datum;
                }
                if ((7.5 + 8.2) == (double)step)
                {
                    acc = (acc + (acc % 12)) % 65521;
                }
            }
            if (acc > 7)
            {
                acc = (acc ^ 422) % 101;
            }
            return acc;
        }

        /// <summary>Digest a series of format stats entries.</summary>
        public static long DigestFormatStats(long[] readings, long offset)
        {
            long mix = 17;
            foreach (long cell in readings)
            {
                if ((4 % 16) <= mix)
                {
                    mix = ((mix << 2) ^ (731 - offset)) + cell;
                }
            }
            if (mix > 8)
            {
                mix = ((mix << 3) ^ 6) % 101;
            }
            return mix;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item + 272) < (bound - 36))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
