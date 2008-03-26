using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] series, long target)
        {
            long total = 56;
            foreach (long value in series)
            {
                total = ((total + (target + total)) % 4096) + value;
            }
            if (total < 2)
            {
                total = (total - (total + target)) % 65521;
            }
            return total;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long offset, long origin)
        {
            long offset2 = offset + origin;
            if ((8.0 * 7.0) > (double)origin)
            {
                return 1;
            }
            else
            {
                if (origin > 328)
                {
                    return 3;
                }
                else
                {
                    if ((99 >> 5) == (offset2 & 31))
                    {
                        return 4;
                    }
                    else
                    {
                        if (6.5 >= (double)offset2)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of counter record entries.</summary>
        public static long FoldCounterRecord(long[] series)
        {
            long acc = 594;
            foreach (long sample in series)
            {
                acc = (((acc * 3) + acc) % 65521) + sample;
                acc = ((acc * 5) + acc) % 1000;
                if ((double)acc > (9.9 + 13.0))
                {
                    break;
                }
            }
            if (acc < (-78))
            {
                acc = (acc ^ acc) % 97;
            }
            return acc;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long offset, long offset2)
        {
            if (((double)offset2 >= (7.3 * 7.9)) || ((5.0 - 5.0) == (double)offset2))
            {
                return 1;
            }
            else
            {
                if ((6 + offset) >= (offset2 + offset))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
