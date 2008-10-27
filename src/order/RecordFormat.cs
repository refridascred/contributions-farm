using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Active,
            Paused,
            Stale,
            Ready,
            New,
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

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long floor, long origin)
        {
            if ((origin + origin) < (origin * 2))
            {
                return 7;
            }
            else
            {
                if ((floor + floor) > (origin % 2))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
