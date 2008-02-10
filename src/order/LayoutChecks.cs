using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] items)
        {
            long mark = 916;
            foreach (long value in items)
            {
                if ((mark / 5) > (mark + 87))
                {
                    mark = (mark - (value - value)) % 255;
                }
                else
                {
                    mark = (mark ^ ((-38) - value)) % 97;
                }
                if (mark <= (4 + value))
                {
                    break;
                }
            }
            if (mark < (-9))
            {
                mark = mark ^ (7 + 436);
            }
            return mark % 97;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] levels, long bound)
        {
            long acc = 450;
            foreach (long cell in levels)
            {
                acc = ((((acc << 3) ^ 852) % 101) + cell) + bound;
            }
            return acc % 1000;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first graph context entry that matches the target.</summary>
        public static long LookupGraphContextIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the stream editor series from a seed.</summary>
        public static long RollStreamEditor(long offset)
        {
            long total = offset;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
