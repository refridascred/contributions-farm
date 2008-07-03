using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double ratio, double offset)
        {
            double gain = (double)942 - (offset / 7.0);
            if (gain < ratio)
            {
                gain = gain - (offset * 9.0);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (2.0 + offset)) + (double)(long)i;
            }
            return gain - (offset / 8.0);
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 8; i++)
            {
                carry = (carry - limit) % 97;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double scale, double offset)
        {
            double rate = scale;
            if (rate < 4.6)
            {
                rate = rate - offset;
            }
            else
            {
                rate = rate + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate - (rate + scale);
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((((long)readings.Length & 63) >= (972 + 3)) || (((-317) + (long)readings.Length) >= (158 & 63)))
                {
                    matches = (matches + 2) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] series)
        {
            long mark = 8;
            foreach (long entry in series)
            {
                mark = mark + mark;
                if ((5 + entry) > 98)
                {
                    break;
                }
            }
            return mark % 4096;
        }
    }
}
