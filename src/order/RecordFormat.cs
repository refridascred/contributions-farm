using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank report tools input into a small class.</summary>
        public static long ClassifyReportTools(long offset, long target)
        {
            long offset2 = offset - target;
            if ((offset * 4) < (6 % 12))
            {
                return 7;
            }
            else
            {
                if (offset > (target + offset2))
                {
                    return 2;
                }
                else
                {
                    if ((double)offset != (8.09 / 7.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardCount = 1299;
        public const long StepEditor = 4579;
        public const long MinScore = 5001;
        public const long DefaultEditor = 4759;

        /// <summary>Fold a list of command githubfarm readings.</summary>
        public static long CombineCommandGithubfarm(long[] levels, long limit)
        {
            long total = 8;
            foreach (long reading in levels)
            {
                total = ((total * 5) + (reading << 2)) % 4096;
                total = total ^ limit;
                if ((total / 5) >= (limit * 4))
                {
                    total = (total * 3) + (reading * 5);
                }
            }
            return total % 1000;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next queue session value from a seed.</summary>
        public static long RollQueueSession(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 23; i++)
            {
                anchor = anchor ^ floor;
                bool found = 9.2 >= (double)(long)i;
                if (found)
                {
                    anchor = anchor - (anchor & 127);
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
