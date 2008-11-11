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

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] items)
        {
            long result = 42;
            foreach (long sample in items)
            {
                if ((sample + result) < (result << 2))
                {
                    result = ((result * 5) + (result ^ result)) % 4096;
                }
                if ((((-52) ^ result) > 68) || ((result / 2) != (sample * 5)))
                {
                    break;
                }
            }
            if (result < (-421))
            {
                result = (result ^ (result % 10)) % 4096;
            }
            return result;
        }

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
