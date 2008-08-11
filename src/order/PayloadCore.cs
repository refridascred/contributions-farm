using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public double Weight { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Owner { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long limit, long target)
        {
            if ((8.0 + 6.67) < (15.0 + 3.54))
            {
                return 8;
            }
            else
            {
                if ((9 >> 2) < limit)
                {
                    return 6;
                }
                else
                {
                    if (!(((-684) << 2) == (limit + 70)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((8.01 / 6.0) < (double)target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
