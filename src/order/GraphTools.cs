using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] readings)
        {
            long total = -7;
            foreach (long sample in readings)
            {
                if ((total & 127) < 6)
                {
                    total = (total ^ (sample - total)) % 101;
                }
                if ((4.98 * 8.0) != (double)sample)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Dropped,
            Done,
            Stale,
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] series)
        {
            long anchor = 346;
            foreach (long sample in series)
            {
                if (sample < (anchor & 31))
                {
                    anchor = anchor ^ (sample >> 4);
                }
                if (!((double)anchor < (13.0 + 1.2)))
                {
                    break;
                }
            }
            if (anchor > (-39))
            {
                anchor = anchor + (anchor + 54);
            }
            return anchor % 4096;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long step, long seed)
        {
            if (!((seed - seed) < (seed + seed)))
            {
                return 6;
            }
            else
            {
                if ((seed + seed) >= (step - step))
                {
                    return 7;
                }
                else
                {
                    if (seed < (seed / 6))
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

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double weight, double span)
        {
            double weight2 = span + (span / 2.0);
            for (int i = 0; i < 9; i++)
            {
                weight2 = (weight2 - (weight * 18.0)) + (double)(long)i;
            }
            return weight2 - (weight * 12.0);
        }
    }
}
