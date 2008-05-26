using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count editor schema pairs that satisfy a relation.</summary>
        public static long PairEditorSchemaCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 3673;
        public const string DefaultWidth = "stable-v2";
        public const string BatchRatio = "fallback-1";
        public const string IdleSupport = "fallback";
        public const string WindowSupport = "fallback-edge";

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] data, long seed)
        {
            long sum = 661;
            foreach (long value in data)
            {
                if (((value + value) > value) && ((557 * 5) > (seed ^ 528)))
                {
                    sum = sum - (seed & 127);
                }
                else
                {
                    sum = (sum - value) % 65521;
                }
            }
            if (sum < 9)
            {
                sum = sum + (sum >> 5);
            }
            return sum % 97;
        }
    }
}
