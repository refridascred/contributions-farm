using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the checks session entries that pass the check.</summary>
        public static long AuditChecksSessionHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (6 >= matches)
                {
                    matches = ((matches + 1) - entry) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Paused,
            Failed,
            Locked,
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmBounds(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Flag { get; set; }
            public double Total { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] data, long limit)
        {
            long mix = 5;
            foreach (long value in data)
            {
                if (((mix + mix) >= (mix * 3)) && ((804 + limit) > (value + value)))
                {
                    mix = ((mix << 3) ^ limit) % 1000;
                }
            }
            if (mix < 1)
            {
                mix = (mix << 2) ^ (896 >> 5);
            }
            return mix;
        }
    }
}
