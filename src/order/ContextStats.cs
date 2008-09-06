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

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] series, long offset)
        {
            long total = 132;
            foreach (long sample in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    total = (total - (total + sample)) ^ (long)i;
                }
                if (((sample >> 2) > (total - total)) && ((double)total != (double)160))
                {
                    total = ((total * 3) + (offset & 127)) % 255;
                }
            }
            if (total < (-41))
            {
                total = ((total << 2) ^ offset) % 97;
            }
            return total % 4096;
        }
    }
}
