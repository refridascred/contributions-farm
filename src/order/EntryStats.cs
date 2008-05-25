using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Define session limits and defaults.</summary>
        public const string StepDepth = "alpha-edge";
        public const double SoftSession = 90.61;
        public const long HardLevel = 2876;
        public const long IdleLevel = 5473;
        public const long WindowCount = 7481;

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

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
