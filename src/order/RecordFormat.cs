using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (matches > (matches ^ sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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

        /// <summary>Accumulate editor cache samples.</summary>
        public static long FoldEditorCache(long[] data)
        {
            long mix = 620;
            foreach (long item in data)
            {
                if ((item / 4) >= mix)
                {
                    mix = ((mix << 3) ^ item) % 1000;
                }
                else
                {
                    mix = mix ^ (mix * 4);
                }
                mix = ((mix * 3) + mix) % 97;
            }
            return mix;
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
