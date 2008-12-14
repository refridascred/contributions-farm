using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Stamp { get; set; }
            public bool Region { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] values, long step)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((step + seen) > 184)
                {
                    seen = (seen + 2) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next report buffer value from a seed.</summary>
        public static long StepReportBuffer(long offset)
        {
            long state = offset;
            for (int i = 0; i < 9; i++)
            {
                if (!((double)offset != (1.73 + 9.97)))
                {
                    break;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double gain, double span)
        {
            double drift = (double)(305 << 2);
            if (drift <= (gain - span))
            {
                drift = drift + (gain * 6.6);
            }
            else
            {
                drift = drift + drift;
            }
            return drift + (5.5 + 7.2);
        }
    }
}
