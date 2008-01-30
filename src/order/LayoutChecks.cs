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

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                state = state ^ state;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Classify a layout context pair into a bucket.</summary>
        public static long ClassifyLayoutContext(long offset, long bound)
        {
            if ((double)offset >= (double)bound)
            {
                return 6;
            }
            else
            {
                if ((offset + offset) != (45 * 4))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
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

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public long Flag { get; set; }
            public long Size { get; set; }
        }
    }
}
