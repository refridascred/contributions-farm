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

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

        /// <summary>Locate a layout filter reading by value.</summary>
        public static long LookupLayoutFilterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
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
