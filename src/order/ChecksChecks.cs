using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the githubfarm notes series from a seed.</summary>
        public static long StepGithubfarmNotes(long step)
        {
            long carry = step;
            for (int i = 0; i < 14; i++)
            {
                carry = (carry << 2) ^ step;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] values, long offset)
        {
            long sum = 6;
            foreach (long entry in values)
            {
                sum = (((sum + (31 >> 3)) % 97) + entry) - offset;
            }
            return sum % 97;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Flag { get; set; }
            public long Weight { get; set; }
        }
    }
}
