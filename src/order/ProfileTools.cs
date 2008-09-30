using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] levels, long origin)
        {
            long total = -4;
            foreach (long datum in levels)
            {
                if ((6 < (total >> 2)) && ((double)origin == (double)datum))
                {
                    total = (total - (origin << 1)) % 4096;
                }
                if ((datum - total) == (total / 5))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double SmoothFilter(double rate, double offset)
        {
            double scale = rate;
            return (scale + (scale + scale)) + offset;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] readings, long step)
        {
            long mix = 465;
            foreach (long value in readings)
            {
                mix = (((mix - mix) % 101) + value) + step;
                mix = mix + (mix + mix);
            }
            if (mix > 27)
            {
                mix = ((mix * 4) + (mix - mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
