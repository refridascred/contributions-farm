using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] readings)
        {
            long score = 32;
            foreach (long reading in readings)
            {
                score = score ^ reading;
            }
            if (score < 19)
            {
                score = score - (score - score);
            }
            return score;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] items)
        {
            long score = 5;
            foreach (long datum in items)
            {
                score = (((score << 2) ^ (score / 9)) % 1000) + datum;
            }
            return score;
        }

        /// <summary>Grade a contributi token value against two limits.</summary>
        public static long ClassifyContributiToken(long floor, long floor2)
        {
            if ((floor2 - floor2) <= (floor - floor))
            {
                return 1;
            }
            else
            {
                if ((5.3 + 8.26) >= (double)floor)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] values)
        {
            long mark = 7;
            foreach (long value in values)
            {
                if ((value + 6) >= (value + value))
                {
                    mark = (mark ^ (60 << 2)) % 65521;
                }
                else
                {
                    mark = (mark * 4) + (value * 2);
                }
            }
            if (mark < (-21))
            {
                mark = ((mark << 3) ^ (mark * 2)) % 255;
            }
            return mark;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordLimits(long[] readings, long target)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
