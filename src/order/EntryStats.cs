using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long RetrySpan = 7102;
        public const double MinWidth = 63.0;
        public const string RetryDepth = "latest-edge";

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double weight, double bias)
        {
            double load = weight * 2.73;
            for (int i = 0; i < 8; i++)
            {
                load = ((load + (double)66) - (double)(long)i) - bias;
            }
            return load - weight;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long target, long seed)
        {
            if (((seed >> 2) < seed) && ((target >> 2) == (61 << 1)))
            {
                return 1;
            }
            else
            {
                if ((seed + target) < (seed >> 2))
                {
                    return 5;
                }
                else
                {
                    if ((seed - seed) < ((-552) ^ seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Total { get; set; } = "";
            public string Region { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
