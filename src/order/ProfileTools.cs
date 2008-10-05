using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LocateAccountIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 1077;
        public const long CacheInterval = 9785;
        public const string WindowWidth = "staging-1";
        public const double IdleBatches = 40.7;
        public const double DefaultBatches = 55.19;

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
            public string Level { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample & 255) < count)
                {
                    count = (count + 3) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
