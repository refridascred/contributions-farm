using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Find the first entry layout entry that matches the target.</summary>
        public static long SeekEntryLayoutIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] values, long step)
        {
            long acc = 92;
            foreach (long sample in values)
            {
                if (((acc ^ sample) <= (acc + 29)) || ((acc + step) != (sample / 2)))
                {
                    acc = (acc + sample) % 255;
                }
                if (!((sample - acc) == (acc & 63)))
                {
                    acc = (acc - acc) % 97;
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Pending,
            Failed,
            Draft,
            Active,
            Idle,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] samples, long origin)
        {
            long mix = 28;
            foreach (long value in samples)
            {
                mix = (((mix << 3) ^ (870 % 10)) % 101) + value;
                if ((double)origin != (double)mix)
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
