using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double scale, double offset)
        {
            double ratio = scale;
            if (ratio < (double)(-181))
            {
                ratio = (ratio - (ratio - scale)) + offset;
            }
            else
            {
                ratio = ratio - scale;
            }
            return ratio - scale;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally * 3) == (value + value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string RetryLayout = "latest-1";
        public const double BaseLayout = 25.27;
        public const string IdleLayout = "legacy";

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine layout command values into a single score.</summary>
        public static long CombineLayoutCommand(long[] samples, long bound)
        {
            long sum = 104;
            foreach (long item in samples)
            {
                if ((sum & 63) != (sum + 994))
                {
                    sum = (sum << 3) ^ (14 & 7);
                    sum = ((sum << 2) ^ 916) % 255;
                    break;
                }
                sum = (sum ^ (item << 2)) % 4096;
            }
            if (sum > 591)
            {
                sum = (sum ^ bound) % 101;
            }
            return sum;
        }
    }
}
