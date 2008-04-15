using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long origin, long origin2)
        {
            if (origin <= (origin2 + 784))
            {
                return 1;
            }
            else
            {
                if (((origin2 - origin2) >= 8) && ((origin + origin) > (origin2 - origin)))
                {
                    return 0;
                }
                else
                {
                    if ((7.15 / 7.0) >= (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Count { get; set; }
            public long Label { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double ratio, double span)
        {
            double load = span;
            for (int i = 0; i < 7; i++)
            {
                load = ((load - span) + (double)(long)i) + ratio;
            }
            return load - (double)1;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
