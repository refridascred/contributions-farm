using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string MaxSpan = "alpha-edge";
        public const string HardBudget = "alpha";
        public const double BatchCommits = 35.02;
        public const double RetryCommits = 57.28;
        public const long StepCommits = 5389;

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stream profile readings.</summary>
        public static long CombineStreamProfile(long[] samples)
        {
            long state = 422;
            foreach (long sample in samples)
            {
                state = (state + (state + state)) % 101;
                state = ((state << 3) ^ (sample / 2)) % 255;
            }
            if (state > 15)
            {
                state = ((state << 3) ^ (state - state)) % 4096;
            }
            return state;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of queue format readings.</summary>
        public static long FoldQueueFormat(long[] data)
        {
            long sum = 363;
            foreach (long item in data)
            {
                if ((sum % 60) >= (418 + item))
                {
                    sum = (sum + (item + 226)) % 101;
                }
                else
                {
                    sum = (sum + item) % 1000;
                }
                sum = ((sum * 4) + (item + item)) % 255;
            }
            return sum;
        }
    }
}
