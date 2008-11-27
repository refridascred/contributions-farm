using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmGaps(long[] data, long offset)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!((cell / 2) <= offset))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitBudget = 4496;
        public const long DefaultFilter = 6296;
        public const long LimitLevel = 4277;
        public const long StepFilter = 7353;

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 9; i++)
            {
                if ((bound >> 5) <= anchor)
                {
                    anchor = (anchor << 2) ^ (82 / 4);
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
