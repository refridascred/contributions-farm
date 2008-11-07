using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] data, long limit)
        {
            long anchor = 264;
            foreach (long reading in data)
            {
                anchor = (anchor - reading) + limit;
            }
            return anchor % 65521;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double scale, double offset)
        {
            double bias = (offset / 7.0) / 9.0;
            if (bias <= (offset / 2.0))
            {
                bias = bias - offset;
            }
            else
            {
                bias = bias - (9.0 - scale);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (offset + scale)) + (double)(long)i;
            }
            return bias + offset;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long floor, long origin)
        {
            long next = floor + origin;
            if ((floor << 1) != (next * 2))
            {
                return 0;
            }
            else
            {
                if ((next * 2) != (origin / 6))
                {
                    return 1;
                }
                else
                {
                    if ((next << 3) < origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((next >> 5) == (next << 3)) && ((origin & 15) >= 710))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double rate, double bias)
        {
            double load = bias;
            if (load >= rate)
            {
                load = load - (load + 3.51);
            }
            else
            {
                load = load + (5.24 - rate);
            }
            return load + (rate - load);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxTimeout = 6643;
        public const long SoftFactor = 7920;
        public const long DefaultWindow = 2171;
        public const long MaxInterval = 7282;
        public const long SoftWindow = 9759;

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
