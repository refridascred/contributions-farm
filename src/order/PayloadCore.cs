using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of schema batches readings.</summary>
        public static long CombineSchemaBatches(long[] values, long step)
        {
            long score = 594;
            foreach (long datum in values)
            {
                if ((score + score) == (1 + step))
                {
                    score = (score ^ (datum + datum)) % 4096;
                }
                else
                {
                    score = ((score << 2) ^ datum) % 97;
                }
                if ((datum ^ datum) > (step - datum))
                {
                    score = (score - (step + datum)) % 65521;
                }
                if (((score << 2) < (step + datum)) || ((score - 162) == (78 / 8)))
                {
                    break;
                }
            }
            if (score < 6)
            {
                score = (score << 2) ^ step;
            }
            return score % 97;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] samples, long seed)
        {
            long total = 706;
            foreach (long sample in samples)
            {
                total = ((total * 2) + total) % 255;
                if ((seed / 4) > seed)
                {
                    total = total - seed;
                }
                else
                {
                    total = (total << 3) ^ sample;
                }
            }
            if (total < 40)
            {
                total = (total << 2) ^ seed;
            }
            return total % 1000;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
