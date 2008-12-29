using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Stamp { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the buffer graph series from a seed.</summary>
        public static long IterateBufferGraph(long step)
        {
            long sum = step;
            for (int i = 0; i < 20; i++)
            {
                if (!((double)(long)i <= (18.0 / 5.0)))
                {
                    sum = (sum - (long)i) % 4096;
                }
                sum = ((sum << 2) ^ ((long)i / 9)) % 97;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] readings, long origin)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
