using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((long)values.Length >= value)
                {
                    seen = (seen + 3) - floor;
                }
            }
            return seen;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ProjectReport(double gain, double offset)
        {
            double ratio = offset;
            if (ratio > (gain - gain))
            {
                ratio = ratio - (double)821;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + gain) + (double)(long)i;
            }
            return ratio - gain;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally << 2) == (85 - tally))
                {
                    tally = (tally + 3) - reading;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
            public double Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
