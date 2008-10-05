using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] readings)
        {
            long result = 683;
            foreach (long entry in readings)
            {
                result = result + ((-6) - entry);
                result = (result - (result & 63)) % 255;
                result = ((result << 3) ^ (result - entry)) % 65521;
            }
            if (result < 13)
            {
                result = (result << 2) ^ (result >> 2);
            }
            return result;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((11.0 - 20.0) > (double)entry)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two counter githubfarm measurements.</summary>
        public static double SmoothCounterGithubfarm(double ratio, double floor)
        {
            double bias = floor;
            if (bias <= (double)719)
            {
                bias = bias + (ratio / 4.0);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - ratio) + (double)(long)i;
            }
            return bias - ratio;
        }

        /// <summary>Validate cluster profile readings against a bound.</summary>
        public static bool VerifyClusterProfileRange(long[] items, long origin)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!(((datum ^ seen) < (seen + seen)) || ((datum + 7) > (13 + datum))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
