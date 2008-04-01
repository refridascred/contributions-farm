using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] values)
        {
            long mark = 53;
            foreach (long reading in values)
            {
                if (((double)mark < (6.0 * 20.0)) || ((8.0 - 1.24) > (double)reading))
                {
                    mark = mark ^ mark;
                }
                else
                {
                    mark = (mark + (reading + mark)) % 1000;
                }
            }
            if (mark < 35)
            {
                mark = (mark ^ (85 + 214)) % 4096;
            }
            return mark;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
