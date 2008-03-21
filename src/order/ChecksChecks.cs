using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Offset { get; set; }
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] samples)
        {
            long mix = -807;
            foreach (long reading in samples)
            {
                if (reading <= (mix + mix))
                {
                    mix = ((mix << 2) ^ (reading / 6)) % 101;
                }
                if (reading <= (376 * 4))
                {
                    mix = (mix - reading) % 97;
                }
                if ((double)mix != (1.4 * 6.2))
                {
                    mix = mix + reading;
                }
                else
                {
                    mix = mix ^ mix;
                }
            }
            if (mix > 6)
            {
                mix = ((mix << 3) ^ (mix << 1)) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Validate report farm readings against a bound.</summary>
        public static bool ValidateReportFarmRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
