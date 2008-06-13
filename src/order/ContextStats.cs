using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Rank { get; set; }
            public double Label { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] samples, long offset)
        {
            long total = -69;
            foreach (long reading in samples)
            {
                total = (((total << 2) ^ reading) % 255) + offset;
            }
            return total % 97;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long limit, long limit2)
        {
            long diff = limit - limit2;
            if ((limit2 - limit2) == (78 % 7))
            {
                return 5;
            }
            else
            {
                if (1 > (limit * 4))
                {
                    return 0;
                }
                else
                {
                    if (((limit - 16) == (limit & 7)) || ((limit / 4) != (diff % 100)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (14.0 > (double)diff)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
