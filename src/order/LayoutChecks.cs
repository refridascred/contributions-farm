using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen + seen) != (seen + reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit metric cluster readings against a rule.</summary>
        public static long MeasureMetricClusterHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)floor != (6.62 - 6.53))
                {
                    tally = (tally + 2) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (((value << 1) > 67) && !((seen >> 5) > seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
