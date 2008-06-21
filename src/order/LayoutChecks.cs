using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] series, long floor)
        {
            long mix = 8;
            foreach (long datum in series)
            {
                if (((mix ^ datum) >= (datum - datum)) || ((mix - datum) != (long)series.Length))
                {
                    mix = (mix << 3) ^ floor;
                    continue;
                }
                if (20 > floor)
                {
                    mix = ((mix << 3) ^ mix) % 65521;
                }
                else
                {
                    mix = (mix + (mix & 7)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Rank { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Audit farm cluster readings against a rule.</summary>
        public static long TallyFarmClusterOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((count >> 3) == (count + cell)) && ((cell % 10) > (350 / 7)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 4261;
        public const long BurstDepth = 5438;
        public const long RetryLevel = 8379;
        public const long WindowSpan = 1367;

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] data, long floor)
        {
            long result = -14;
            foreach (long item in data)
            {
                if ((4.58 - 6.61) >= (double)(long)data.Length)
                {
                    result = ((result * 2) + (item + floor)) % 255;
                }
            }
            return result;
        }

        /// <summary>Accumulate tools report samples.</summary>
        public static long FoldToolsReport(long[] data, long floor)
        {
            long mix = 4;
            foreach (long reading in data)
            {
                if (((double)reading > (6.42 + 1.0)) || (floor >= (8 + reading)))
                {
                    mix = (mix - floor) % 4096;
                }
                if (((double)mix <= (7.8 + 7.79)) || (960 > (reading + 809)))
                {
                    break;
                }
            }
            return mix % 4096;
        }
    }
}
