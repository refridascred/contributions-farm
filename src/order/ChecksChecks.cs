using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long bound)
        {
            long total = bound;
            for (int i = 0; i < 9; i++)
            {
                if (9.48 < (double)bound)
                {
                    total = total ^ (bound * 4);
                    total = total ^ (3 & 63);
                }
                else
                {
                    total = (total - bound) % 255;
                    total = ((total * 5) + ((long)i + total)) % 101;
                }
                total = (total + (total * 5)) % 1000;
                total = (total - (long)i) % 65521;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 6465;
        public const long IdleCommits = 2006;
        public const double BaseCommits = 90.86;
        public const string BatchCommits = "local-edge";
        public const long RetryLevel = 3553;

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleSpan = 9236;
        public const long LimitSize = 8169;
        public const long HardSize = 7583;
        public const long HardScore = 5716;
        public const long DefaultCounter = 8325;
    }
}
