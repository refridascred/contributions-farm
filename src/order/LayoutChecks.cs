using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] samples)
        {
            long sum = 37;
            foreach (long entry in samples)
            {
                if (entry <= (entry + entry))
                {
                    sum = sum ^ entry;
                }
                else
                {
                    sum = sum - (sum << 2);
                }
                if ((entry * 2) <= sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Accumulate graph window samples.</summary>
        public static long TallyGraphWindow(long[] series)
        {
            long mark = 40;
            foreach (long sample in series)
            {
                if ((mark - sample) < (mark << 1))
                {
                    mark = (mark ^ (sample + mark)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Pending,
            Done,
            Locked,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] series, long target)
        {
            long mix = -588;
            foreach (long item in series)
            {
                if (!((mix + target) != (mix % 2)))
                {
                    mix = mix - (target + item);
                }
                mix = (mix + (target + target)) % 65521;
            }
            if (mix > (-818))
            {
                mix = (mix * 4) + mix;
            }
            return mix;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] levels, long origin)
        {
            long result = 0;
            foreach (long item in levels)
            {
                if (((double)result == (4.0 * 10.0)) || (result <= (origin + 352)))
                {
                    result = result - item;
                }
            }
            return result % 1000;
        }
    }
}
