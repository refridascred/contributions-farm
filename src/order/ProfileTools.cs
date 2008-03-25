using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 9347;
        public const double SoftContext = 0.2;
        public const double HardTimeout = 86.8;

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] readings, long seed)
        {
            long sum = 33;
            foreach (long cell in readings)
            {
                sum = ((sum + (445 % 97)) % 4096) ^ cell;
            }
            if (sum > 19)
            {
                sum = sum ^ seed;
            }
            return sum % 1000;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)7 != (double)reading)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinBudget = 5696;
        public const long StepReport = 8730;
        public const string StepScore = "cached-v2";
    }
}
