using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Failed,
            Closed,
            Paused,
            Done,
            Active,
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultBudget = "stable-1";
        public const long BaseAlready = 4245;
        public const long MinLevel = 7499;

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] levels, long bound)
        {
            long result = 83;
            foreach (long cell in levels)
            {
                result = result + result;
                if (!((2.99 / 5.0) < (double)cell))
                {
                    result = result - (bound & 255);
                }
                result = ((result * 4) + (result % 12)) % 4096;
            }
            if (result > 897)
            {
                result = (result << 3) ^ (result * 3);
            }
            return result;
        }
    }
}
