using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Synced,
            Ready,
            Queued,
            New,
            Failed,
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Size { get; set; }
            public string Token { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long step, long offset)
        {
            if (20.0 > (double)step)
            {
                return 6;
            }
            else
            {
                if ((double)step > (7.7 + 9.38))
                {
                    return 1;
                }
                else
                {
                    if ((offset % 64) <= (step + 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step >> 2) <= step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                if ((4.37 * 8.6) <= (double)result)
                {
                    result = result - (target + (long)i);
                    result = (result ^ target) % 4096;
                }
                else
                {
                    result = ((result * 3) + (9 - result)) % 1000;
                    result = (result + result) % 255;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Digest a series of layout route entries.</summary>
        public static long TallyLayoutRoute(long[] samples)
        {
            long mix = 232;
            foreach (long reading in samples)
            {
                if (8 > (reading + reading))
                {
                    mix = mix - (173 % 60);
                }
            }
            if (mix < 0)
            {
                mix = ((mix << 3) ^ (mix + 65)) % 1000;
            }
            return mix;
        }
    }
}
