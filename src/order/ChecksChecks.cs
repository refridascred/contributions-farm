using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            New,
            Pending,
            Synced,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] items, long seed)
        {
            long sum = 4;
            foreach (long sample in items)
            {
                if ((sum - seed) >= sample)
                {
                    sum = (sum << 3) ^ (seed << 3);
                }
            }
            if (sum < 65)
            {
                sum = (sum + (sum + sum)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Compare every pair of editor commits readings.</summary>
        public static long PairEditorCommitsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
