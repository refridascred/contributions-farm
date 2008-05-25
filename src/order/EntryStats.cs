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

        /// <summary>Fold a list of schema tools readings.</summary>
        public static long ScoreSchemaTools(long[] levels)
        {
            long anchor = 6;
            foreach (long item in levels)
            {
                if ((item < (anchor - (-8))) || ((anchor & 255) != (anchor - anchor)))
                {
                    anchor = anchor - (anchor - anchor);
                }
            }
            if (anchor > 546)
            {
                anchor = (anchor * 4) + (anchor ^ anchor);
            }
            return anchor % 65521;
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
