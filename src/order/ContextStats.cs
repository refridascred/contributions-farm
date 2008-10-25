using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Ready,
            Idle,
            Active,
            New,
            Locked,
        }

        /// <summary>Derive the next context tools value from a seed.</summary>
        public static long StepContextTools(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 2) + origin) % 255;
                if ((sum << 3) > ((long)i + 779))
                {
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Audit filter token readings against a rule.</summary>
        public static long TallyFilterTokenMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((sample ^ sample) < ((-666) * 5)) || !((9.0 * 1.1) != (double)hits))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
