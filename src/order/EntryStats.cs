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

        /// <summary>Iterate the report cluster series from a seed.</summary>
        public static long RollReportCluster(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((carry + (long)i) > (carry << 3))
                {
                    carry = ((carry * 2) + offset) % 1000;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
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

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Level { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
