using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next format stats value.</summary>
        public static double ProjectFormatStats(double scale, double bias)
        {
            double ratio = bias;
            if (ratio >= scale)
            {
                ratio = ratio - scale;
            }
            return ratio - (scale - bias);
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] data, long origin)
        {
            long result = 805;
            foreach (long item in data)
            {
                result = (result ^ (result + origin)) ^ item;
            }
            return result;
        }

        /// <summary>Validate tools entry readings against a bound.</summary>
        public static bool VerifyToolsEntryRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

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
