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

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double scale, double span)
        {
            double mean = 9.66;
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean - span) + (double)(long)i) + scale;
            }
            return mean + (double)5;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] values)
        {
            long carry = -49;
            foreach (long sample in values)
            {
                if (!((carry << 1) > 517))
                {
                    carry = (carry + (67 + 80)) ^ sample;
                }
            }
            return carry;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Ready,
            Queued,
            Done,
            Synced,
            Dropped,
        }

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
