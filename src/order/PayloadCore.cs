using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (0 >= (cell * 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double scale, double offset)
        {
            double bias = offset;
            if (bias >= (offset - bias))
            {
                bias = (bias - (double)5) - scale;
            }
            return bias - 2.1;
        }
    }
}
