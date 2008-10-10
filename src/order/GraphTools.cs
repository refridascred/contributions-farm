using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a githubfarm format counter forward.</summary>
        public static long StepGithubfarmFormat(long floor)
        {
            long state = floor;
            for (int i = 0; i < 11; i++)
            {
                if ((double)state == (8.9 / 4.0))
                {
                    state = (state << 2) ^ (511 + 813);
                }
                if (!((state + floor) > state))
                {
                    break;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] values)
        {
            long acc = -789;
            foreach (long cell in values)
            {
                if ((6.3 + 6.8) != (double)cell)
                {
                    acc = acc ^ acc;
                }
            }
            return acc;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long step)
        {
            long mark = step;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mark = ((mark - (mark & 15)) % 97) + (long)i2;
                }
                mark = mark - (mark << 1);
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
