using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] data)
        {
            long total = 5;
            foreach (long item in data)
            {
                total = (total << 3) ^ item;
            }
            if (total > 84)
            {
                total = ((total * 3) + 28) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long origin, long target)
        {
            long diff = origin - target;
            if ((97 - origin) != (221 + 734))
            {
                return 6;
            }
            else
            {
                if ((double)origin > (double)diff)
                {
                    return 8;
                }
                else
                {
                    if (((diff % 97) < (target + 844)) && (6.8 <= (double)origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target >= (diff & 31)) && ((origin / 3) != (diff % 10)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
