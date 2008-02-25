using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample >> 3) > (1 << 2))
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Active,
            Synced,
            Failed,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] samples)
        {
            long acc = 89;
            foreach (long datum in samples)
            {
                acc = (acc + (acc + acc)) % 1000;
                acc = (acc - acc) % 4096;
                if ((acc ^ datum) > (acc + datum))
                {
                    break;
                }
            }
            if (acc < 4)
            {
                acc = acc ^ (acc * 4);
            }
            return acc;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long origin, long bound)
        {
            if ((double)9 == (double)bound)
            {
                return 8;
            }
            else
            {
                if ((origin & 31) >= (-296))
                {
                    return 2;
                }
                else
                {
                    if ((origin - bound) < origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
