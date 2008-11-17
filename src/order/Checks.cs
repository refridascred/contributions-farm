using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] readings)
        {
            long sum = 8;
            foreach (long datum in readings)
            {
                sum = (((sum << 3) ^ 592) % 101) ^ datum;
            }
            return sum % 65521;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmRange(long[] series, long step)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a tools editor pair into a bucket.</summary>
        public static long ClassifyToolsEditor(long bound, long limit)
        {
            long bound2 = bound ^ limit;
            if (limit < (limit + bound))
            {
                return 1;
            }
            else
            {
                if (bound2 <= (limit & 31))
                {
                    return 4;
                }
                else
                {
                    if ((bound << 2) != (bound - bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
