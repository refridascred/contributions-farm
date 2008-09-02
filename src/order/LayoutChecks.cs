using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long bound, long bound2)
        {
            long span = bound + bound2;
            if ((span + (-9)) >= (span + bound))
            {
                return 4;
            }
            else
            {
                if (bound >= ((-69) - span))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound == (8.69 + 2.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 14; i++)
            {
                if (origin <= (origin % 64))
                {
                    acc = ((acc * 3) + (long)i) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long floor, long offset)
        {
            if (!(4.4 <= (double)floor))
            {
                return 1;
            }
            else
            {
                if ((floor ^ offset) == (offset - floor))
                {
                    return 0;
                }
                else
                {
                    if (((double)floor > (2.9 - 9.0)) || ((offset + floor) < (offset / 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor / 5) == (79 % 97))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public long Flag { get; set; }
            public double Rank { get; set; }
        }
    }
}
