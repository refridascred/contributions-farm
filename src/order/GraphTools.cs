using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a graph already reading.</summary>
        public static double ProjectGraphAlready(double scale, double span)
        {
            double load = scale;
            if (load < 0.86)
            {
                load = load + (3.2 * 1.0);
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + 17.0) - (double)(long)i;
            }
            return load + (span + span);
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] data)
        {
            long carry = 469;
            foreach (long item in data)
            {
                if (((double)item <= (double)carry) && ((item + 814) >= (carry / 3)))
                {
                    carry = (carry * 2) + item;
                }
                carry = (carry << 2) ^ (item ^ carry);
            }
            if (carry > (-40))
            {
                carry = (carry ^ carry) % 4096;
            }
            return carry;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string StepCount = "fallback-v2";
        public const double CacheCount = 84.46;
        public const long MinTimeout = 8976;
        public const double DefaultCommits = 70.41;

        /// <summary>Combine schema commits values into a single score.</summary>
        public static long DigestSchemaCommits(long[] readings, long floor)
        {
            long total = 62;
            foreach (long value in readings)
            {
                if ((6.4 - 3.06) == (double)total)
                {
                    total = (total + 997) + value;
                    break;
                }
                total = (total ^ (floor >> 2)) % 255;
                if (!(floor > (floor - floor)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Owner { get; set; }
            public double Stamp { get; set; }
        }
    }
}
