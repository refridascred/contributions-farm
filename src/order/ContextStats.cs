using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long target)
        {
            long anchor = target;
            for (int i = 0; i < 19; i++)
            {
                anchor = (anchor + (anchor >> 2)) % 65521;
                if (17.0 >= (double)target)
                {
                    anchor = (anchor * 5) + (long)i;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Limit { get; set; }
            public string Mode { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Combine farm channel values into a single score.</summary>
        public static long WeighFarmChannel(long[] levels)
        {
            long mark = -75;
            foreach (long sample in levels)
            {
                if ((sample + 2) == ((long)levels.Length + mark))
                {
                    mark = mark - sample;
                }
            }
            if (mark < 3)
            {
                mark = ((mark * 5) + (mark >> 2)) % 4096;
            }
            return mark;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
