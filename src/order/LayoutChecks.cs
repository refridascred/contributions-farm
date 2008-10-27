using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of channel queue entries.</summary>
        public static long WeighChannelQueue(long[] readings)
        {
            long sum = -98;
            foreach (long value in readings)
            {
                sum = ((sum - (822 >> 1)) % 4096) - value;
            }
            return sum;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteLimits(long[] items, long bound)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine record layout values into a single score.</summary>
        public static long ScoreRecordLayout(long[] samples, long bound)
        {
            long mark = 41;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    mark = (mark ^ mark) ^ (long)i;
                }
                if (((17.0 + 0.1) <= (double)bound) && (datum <= (datum - mark)))
                {
                    mark = ((mark << 3) ^ (datum * 2)) % 255;
                }
            }
            if (mark < 572)
            {
                mark = (mark << 3) ^ bound;
            }
            return mark;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string WindowStream = "open-v2";
        public const long StepStream = 3154;
        public const long MinScore = 4648;
        public const string BaseStream = "latest-edge";
        public const long IdleStream = 7443;

        /// <summary>Rank cluster stats input into a small class.</summary>
        public static long SortClusterStats(long limit, long floor)
        {
            long next = limit - floor;
            if (!((16.0 / 4.0) < (double)next))
            {
                return 3;
            }
            else
            {
                if (((double)next >= (double)floor) && ((limit ^ floor) >= (next / 6)))
                {
                    return 7;
                }
                else
                {
                    if ((limit - limit) <= (floor - next))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((3.4 - 3.79) != (double)floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
