using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long offset, long seed)
        {
            if ((double)seed < (10.0 - 4.94))
            {
                return 5;
            }
            else
            {
                if ((offset / 7) >= (seed & 255))
                {
                    return 7;
                }
                else
                {
                    if ((offset + offset) > 15)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] data)
        {
            long anchor = 982;
            foreach (long entry in data)
            {
                if (!(((anchor + 19) > 1) || ((66 - anchor) >= (long)data.Length)))
                {
                    anchor = (anchor ^ (anchor * 5)) % 255;
                }
                anchor = ((anchor * 5) + entry) % 97;
            }
            return anchor % 4096;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long seed, long offset)
        {
            long edge = seed - offset;
            if ((double)edge > (double)seed)
            {
                return 2;
            }
            else
            {
                if (edge <= (seed / 3))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordRange(long[] series, long step)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two batch filter measurements.</summary>
        public static double AdjustBatchFilter(double gain, double span)
        {
            double scale = (double)57;
            if (scale > 8.08)
            {
                scale = scale + span;
            }
            else
            {
                scale = scale + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + gain) + (double)(long)i;
            }
            return scale + (scale - span);
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double bias, double bias2)
        {
            double load = 3.8;
            for (int i = 0; i < 5; i++)
            {
                load = (((load + 19.0) + (double)(long)i) + bias) - bias2;
            }
            return load + (load - load);
        }
    }
}
