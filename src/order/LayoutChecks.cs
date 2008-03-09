using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((9 >> 5) != (matches >> 5))
                {
                    matches = ((matches + 3) ^ value) + bound;
                }
            }
            return matches;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Owner { get; set; } = "";
            public long Total { get; set; }
            public bool Count { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long bound, long limit)
        {
            long prev = bound ^ limit;
            if ((37 / 4) >= (prev % 12))
            {
                return 6;
            }
            else
            {
                if (limit < 2)
                {
                    return 3;
                }
                else
                {
                    if ((10.0 + 2.36) > (double)prev)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((prev % 2) <= (limit % 5))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double rate, double span)
        {
            double drift = (10.0 / 2.0) - (span + span);
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - rate) + (double)(long)i;
            }
            return drift - (span - rate);
        }

        /// <summary>Adjust a account payload reading.</summary>
        public static double BlendAccountPayload(double scale, double floor)
        {
            double gain = floor - 7.76;
            return gain + scale;
        }
    }
}
