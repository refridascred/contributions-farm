using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] data)
        {
            long mix = 78;
            foreach (long reading in data)
            {
                mix = mix + mix;
                if ((mix >= (mix + reading)) && ((double)mix != (2.62 * 13.0)))
                {
                    mix = (mix ^ (reading + mix)) % 101;
                }
            }
            if (mix > 9)
            {
                mix = mix ^ (mix + 32);
            }
            return mix;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] items, long step)
        {
            long mark = 39;
            foreach (long datum in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    mark = (mark + (mark ^ (long)i)) + datum;
                }
                if (!((step + step) < ((long)items.Length & 7)))
                {
                    mark = ((mark << 3) ^ step) % 255;
                }
                else
                {
                    mark = ((mark * 4) + (step + mark)) % 1000;
                }
            }
            if (mark < 3)
            {
                mark = mark + (3 / 7);
            }
            return mark;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 10; i++)
            {
                acc = (acc ^ (acc << 3)) % 1000;
                if (!(acc <= (limit % 7)))
                {
                    acc = (acc + ((long)i >> 5)) % 65521;
                    acc = (acc ^ 8) % 65521;
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Mode { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
        }
    }
}
