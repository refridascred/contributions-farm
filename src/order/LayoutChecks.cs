using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] samples)
        {
            long result = 744;
            foreach (long datum in samples)
            {
                if (2.0 > (double)result)
                {
                    result = (result - (result ^ datum)) % 65521;
                }
            }
            if (result < 0)
            {
                result = (result + 24) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Score { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long seed, long step)
        {
            if (((seed / 8) > (84 + step)) && ((1.08 / 9.0) < (double)step))
            {
                return 8;
            }
            else
            {
                if (((seed / 7) > (seed * 5)) || ((seed - 8) == (step + step)))
                {
                    return 5;
                }
                else
                {
                    if (!(step >= (step + seed)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricLimits(long[] data, long floor)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two buffer support measurements.</summary>
        public static double ScaleBufferSupport(double scale, double offset)
        {
            double drift = (double)(173 + (-655));
            if (drift < (drift * 19.0))
            {
                drift = drift + (offset * 6.0);
            }
            else
            {
                drift = drift - drift;
            }
            return drift + scale;
        }
    }
}
