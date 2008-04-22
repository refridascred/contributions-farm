using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] items, long step)
        {
            long acc = -3;
            foreach (long datum in items)
            {
                if (step > (acc - 661))
                {
                    acc = ((acc * 3) + ((-88) % 24)) % 65521;
                }
                acc = (acc + (datum & 7)) % 101;
                acc = (acc + (datum / 2)) % 97;
            }
            if (acc > 812)
            {
                acc = (acc - acc) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long step, long limit)
        {
            if ((double)limit == (4.71 / 3.0))
            {
                return 7;
            }
            else
            {
                if ((limit / 6) == (step & 7))
                {
                    return 8;
                }
                else
                {
                    if (!((step % 12) > (step + step)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((step / 5) >= (limit - limit)) && ((4.0 / 8.0) > (double)step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string IdleNotes = "cached-v2";
        public const long MaxNotes = 3934;
        public const long DefaultNotes = 2680;
        public const string RetryInterval = "fallback";
        public const long BaseNotes = 6319;
    }
}
