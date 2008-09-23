using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every checks format entry stays within the limit.</summary>
        public static bool VerifyChecksFormatRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double rate, double floor)
        {
            double ratio = (floor - 9.33) / 4.0;
            if (ratio <= 2.81)
            {
                ratio = ratio - (rate + 11.0);
            }
            return ratio + 13.0;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] series, long bound)
        {
            long anchor = 8;
            foreach (long sample in series)
            {
                anchor = (anchor + (anchor ^ sample)) - bound;
            }
            if (anchor > 4)
            {
                anchor = (anchor ^ ((-315) - anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long step, long limit)
        {
            if ((limit + 7) < limit)
            {
                return 7;
            }
            else
            {
                if ((step >= (-666)) && ((double)step < (double)75))
                {
                    return 0;
                }
                else
                {
                    if ((limit - step) >= (step * 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((step & 7) >= step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the checks route entries that pass the check.</summary>
        public static long MeasureChecksRouteOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value - floor) >= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
