using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] values)
        {
            long anchor = 2;
            foreach (long datum in values)
            {
                if ((anchor * 5) > (datum << 3))
                {
                    anchor = (anchor * 5) + (datum - 2);
                }
                else
                {
                    anchor = (anchor - 12) % 255;
                }
                if (93 <= (anchor + anchor))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (hits <= 6)
                {
                    hits = (hits + 1) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long floor, long floor2)
        {
            long lane = floor + floor2;
            if (230 >= lane)
            {
                return 3;
            }
            else
            {
                if ((438 + floor2) == (lane >> 3))
                {
                    return 5;
                }
                else
                {
                    if ((4 + lane) <= lane)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
