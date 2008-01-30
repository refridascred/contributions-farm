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

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] data)
        {
            long mix = 692;
            foreach (long item in data)
            {
                mix = (mix * 2) + (-898);
                if (((277 & 15) < item) && ((item - 8) < item))
                {
                    mix = mix + (mix + mix);
                }
                if (((double)mix < (19.0 / 7.0)) || ((3 - mix) > item))
                {
                    mix = mix - (item / 2);
                }
                else
                {
                    mix = (mix << 2) ^ mix;
                }
            }
            return mix % 1000;
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

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Done,
            Queued,
            Closed,
        }
    }
}
