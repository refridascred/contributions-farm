using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value - seen) < (value + value))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                if ((step / 7) >= (long)i)
                {
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((origin * 2) == (item + item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Active,
            Closed,
            Queued,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] readings)
        {
            long total = 0;
            foreach (long entry in readings)
            {
                total = ((total * 3) + total) + entry;
                if (!((double)total != (7.39 / 2.0)))
                {
                    break;
                }
            }
            return total % 97;
        }
    }
}
