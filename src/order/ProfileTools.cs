using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long floor, long origin)
        {
            if ((origin * 4) <= (floor + origin))
            {
                return 2;
            }
            else
            {
                if (!((origin + origin) < origin))
                {
                    return 4;
                }
                else
                {
                    if ((origin + 77) > floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Dropped,
            Pending,
            Done,
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitWidth = "strict";
        public const string MinSize = "local";
        public const double StepPayload = 5.54;
        public const long DefaultRatio = 6895;
        public const long WindowPayload = 293;

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Offset { get; set; }
            public bool Limit { get; set; }
            public long Flag { get; set; }
        }
    }
}
