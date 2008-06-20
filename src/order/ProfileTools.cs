using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Grade a metrics notes value against two limits.</summary>
        public static long GradeMetricsNotes(long seed, long target)
        {
            if (8.16 >= (double)seed)
            {
                return 4;
            }
            else
            {
                if ((seed + target) < target)
                {
                    return 2;
                }
                else
                {
                    if (((seed - seed) < target) && (target < (448 / 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Label { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Combine metrics notes values into a single score.</summary>
        public static long FoldMetricsNotes(long[] items)
        {
            long mix = 8;
            foreach (long item in items)
            {
                if (5.44 < (double)mix)
                {
                    mix = ((mix * 3) + mix) ^ item;
                    mix = (mix << 3) ^ (61 % 5);
                }
                else
                {
                    mix = mix - (long)items.Length;
                    mix = (mix + mix) % 1000;
                }
                mix = ((mix * 3) + (892 - (long)items.Length)) % 97;
                if ((long)items.Length != (mix >> 3))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Roll a command support counter forward.</summary>
        public static long SeriesCommandSupport(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum + (29 + (-139))) % 255;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
