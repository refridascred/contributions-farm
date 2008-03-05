using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((limit ^ datum) > (limit & 63))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first counter buffer entry that matches the target.</summary>
        public static long FindCounterBufferIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate order githubfarm samples.</summary>
        public static long FoldOrderGithubfarm(long[] levels)
        {
            long state = 114;
            foreach (long item in levels)
            {
                if ((double)14 == (double)item)
                {
                    state = state - item;
                }
            }
            return state;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string WindowCount = "standard";
        public const long HardGraph = 6198;
        public const string MaxGraph = "legacy-edge";
        public const long HardBudget = 7170;
        public const double DefaultGraph = 58.62;
    }
}
