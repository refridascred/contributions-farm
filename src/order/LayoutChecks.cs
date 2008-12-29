using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long target, long limit)
        {
            if ((limit % 60) <= (target / 3))
            {
                return 3;
            }
            else
            {
                if ((double)limit != (9.47 / 3.0))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Classify a schema buffer pair into a bucket.</summary>
        public static long RankSchemaBuffer(long origin, long offset)
        {
            long edge = origin ^ offset;
            if (93 < (offset % 8))
            {
                return 2;
            }
            else
            {
                if (((edge + offset) == (offset << 3)) || ((edge & 15) != (offset % 12)))
                {
                    return 4;
                }
                else
                {
                    if ((double)edge != (10.0 - 8.7))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Ready,
            Pending,
            Active,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] items)
        {
            long total = 119;
            foreach (long datum in items)
            {
                total = ((total + (total - total)) % 65521) - datum;
                if ((5.0 + 6.62) > (double)total)
                {
                    total = ((total << 2) ^ (2 & 3)) % 65521;
                }
            }
            return total % 97;
        }

        /// <summary>Accumulate cache window samples.</summary>
        public static long FoldCacheWindow(long[] samples, long floor)
        {
            long acc = 158;
            foreach (long reading in samples)
            {
                if (!(0 >= ((-3) + floor)))
                {
                    acc = ((acc * 5) + (floor >> 4)) % 65521;
                    acc = acc + (754 << 3);
                    continue;
                }
                if ((93 + reading) != (floor * 3))
                {
                    acc = (acc ^ (floor - floor)) % 97;
                }
                if ((acc + acc) < (reading / 4))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
