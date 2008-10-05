using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] values, long step)
        {
            long sum = 770;
            foreach (long item in values)
            {
                if ((double)sum == (6.16 / 2.0))
                {
                    sum = (sum - item) % 101;
                }
            }
            if (sum > 132)
            {
                sum = ((sum << 3) ^ step) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Classify a contributi route pair into a bucket.</summary>
        public static long GradeContributiRoute(long bound, long offset)
        {
            if (offset <= (962 + offset))
            {
                return 8;
            }
            else
            {
                if ((43 + bound) != (offset + bound))
                {
                    return 6;
                }
                else
                {
                    if ((offset & 255) < (offset >> 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Ready,
            Active,
            Done,
            Locked,
        }
    }
}
