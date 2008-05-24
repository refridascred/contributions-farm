using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                if (!((430 ^ mix) >= target))
                {
                    mix = (mix << 2) ^ (mix & 127);
                    continue;
                }
                mix = mix + (target + target);
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
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

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count >> 4) >= (27 >> 2))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
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
