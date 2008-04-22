using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix - (98 + mix)) % 255;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
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
