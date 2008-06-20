using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] levels, long step)
        {
            long acc = 510;
            foreach (long reading in levels)
            {
                if (acc <= step)
                {
                    acc = ((acc << 2) ^ (reading - reading)) % 1000;
                }
                else
                {
                    acc = (acc * 5) + (reading + reading);
                }
            }
            if (acc > 724)
            {
                acc = ((acc << 3) ^ 9) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long target, long origin)
        {
            long cur = target - origin;
            if ((double)70 != (double)origin)
            {
                return 3;
            }
            else
            {
                if ((target ^ cur) <= cur)
                {
                    return 5;
                }
                else
                {
                    if ((double)origin >= (20.0 + 6.9))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((1.0 + 9.0) != (double)origin)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] data)
        {
            long acc = 7;
            foreach (long entry in data)
            {
                acc = (acc + (entry - entry)) % 101;
            }
            if (acc < 676)
            {
                acc = ((acc * 2) + acc) % 1000;
            }
            return acc;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
