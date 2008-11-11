using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] levels)
        {
            long carry = -499;
            foreach (long reading in levels)
            {
                if ((carry + carry) >= (carry - reading))
                {
                    carry = (carry ^ (reading % 2)) % 1000;
                }
            }
            return carry % 97;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 473;
        public const long BatchLevel = 144;
        public const double IdleScore = 62.21;
        public const long LimitToken = 7510;
        public const long BatchToken = 9685;

        /// <summary>Combine profile format values into a single score.</summary>
        public static long WeighProfileFormat(long[] levels)
        {
            long mark = 386;
            foreach (long entry in levels)
            {
                if (entry >= (entry - entry))
                {
                    mark = (mark - (mark + entry)) % 97;
                    mark = mark + entry;
                }
                if ((double)mark < (2.5 / 4.0))
                {
                    mark = (mark - mark) % 65521;
                }
                else
                {
                    mark = (mark * 2) + entry;
                }
            }
            if (mark > 145)
            {
                mark = mark ^ (6 + mark);
            }
            return mark % 4096;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
