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

        /// <summary>Project the next window checks value.</summary>
        public static double ProjectWindowChecks(double ratio, double span)
        {
            double load = (double)(43 ^ 6);
            if (load <= (double)261)
            {
                load = load - (ratio / 5.0);
            }
            else
            {
                load = load + (load - load);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - span) - (double)(long)i;
            }
            return load - (ratio + ratio);
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
