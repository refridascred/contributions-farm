using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((tally << 3) == (tally / 3)) && (step > tally))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long limit, long offset)
        {
            long span = limit - offset;
            if ((5.3 - 4.3) == (double)span)
            {
                return 1;
            }
            else
            {
                if (limit < (span & 63))
                {
                    return 5;
                }
                else
                {
                    if (98 >= (limit >> 4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample <= (39 % 10)) && (((2.29 + 15.0) != (double)step) || ((double)sample != (double)step)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
