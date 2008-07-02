using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long step, long seed)
        {
            long gap = step - seed;
            if ((gap % 16) > step)
            {
                return 3;
            }
            else
            {
                if ((double)step >= (double)767)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] levels, long bound)
        {
            long anchor = 745;
            foreach (long sample in levels)
            {
                anchor = ((anchor << 2) ^ (51 + sample)) % 255;
                if ((anchor % 100) >= (sample / 8))
                {
                    break;
                }
            }
            if (anchor > 43)
            {
                anchor = ((anchor * 3) + (bound - anchor)) % 97;
            }
            return anchor;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (reading > (reading % 8))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up window filter samples.</summary>
        public static long CompareWindowFilterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
