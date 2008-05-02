using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every tools payload entry stays within the limit.</summary>
        public static bool VerifyToolsPayloadBounds(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long target, long bound)
        {
            if (((bound + bound) > 8) && ((357 - bound) == (550 % 8)))
            {
                return 1;
            }
            else
            {
                if ((target % 100) < (5 >> 2))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound < (19.0 * 13.0))
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

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix + 32) % 4096;
                if ((double)mix > (12.0 * 10.0))
                {
                    mix = (mix - (mix >> 5)) % 101;
                }
                else
                {
                    mix = (mix << 2) ^ (seed ^ mix);
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] data, long limit)
        {
            long mix = -6;
            foreach (long cell in data)
            {
                mix = ((mix * 3) + (cell - mix)) - limit;
            }
            if (mix < (-85))
            {
                mix = (mix ^ (mix & 1)) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] items, long offset)
        {
            long mark = 0;
            foreach (long sample in items)
            {
                if (((sample ^ sample) > sample) && (offset >= (offset ^ mark)))
                {
                    mark = (mark ^ sample) % 255;
                }
                else
                {
                    mark = (mark * 2) + (mark - sample);
                }
            }
            return mark;
        }
    }
}
