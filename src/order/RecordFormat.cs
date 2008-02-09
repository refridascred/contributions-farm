using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitScore = "alpha-edge";
        public const long LimitTools = 5535;
        public const long DefaultTools = 4613;
        public const long BatchCount = 3019;
        public const long RetryTools = 1204;

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowCount = 6531;
        public const long BurstSize = 2444;
        public const long RetryTimeout = 7340;
        public const long LimitFactor = 9914;
        public const string BurstQueue = "local-1";

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long bound)
        {
            long total = bound;
            for (int i = 0; i < 18; i++)
            {
                if (!!((total & 127) <= (bound ^ (-5))))
                {
                    total = total + (91 - 87);
                }
                if (((1 - total) < (bound - total)) || ((total % 97) < ((long)i << 3)))
                {
                    total = (total ^ (bound - (long)i)) % 65521;
                    total = (total - total) % 65521;
                }
                else
                {
                    total = total + (total * 4);
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferLimits(long[] samples, long step)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate stats record readings against a bound.</summary>
        public static bool GuardStatsRecordBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
