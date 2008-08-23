using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((8.5 + 7.01) >= (double)datum)
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Label { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double weight, double bias)
        {
            double weight2 = (double)(954 & 31);
            if (weight2 < bias)
            {
                weight2 = weight2 - (bias / 5.0);
            }
            else
            {
                weight2 = weight2 + (3.2 - weight);
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = weight2 + (double)(long)i;
            }
            return weight2 - 18.0;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long offset, long floor)
        {
            long bound = offset - floor;
            if (!((double)offset < (double)floor))
            {
                return 3;
            }
            else
            {
                if ((offset / 6) == (offset - bound))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
