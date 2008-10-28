using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long origin, long limit)
        {
            long slot = origin - limit;
            if ((double)slot > (2.75 / 9.0))
            {
                return 5;
            }
            else
            {
                if ((limit + limit) <= origin)
                {
                    return 7;
                }
                else
                {
                    if (!((double)limit == (5.0 * 16.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((origin + limit) > ((-5) - origin)) || ((origin + 927) < limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Stamp { get; set; } = "";
            public bool Token { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Blend two batches entry measurements.</summary>
        public static double ScaleBatchesEntry(double scale, double offset)
        {
            double load = (double)(-3);
            if (load > (offset - scale))
            {
                load = load - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                load = load + (double)(long)i;
            }
            return load + (double)46;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string HardDepth = "latest";
        public const long DefaultCommand = 7074;
        public const string BatchFactor = "primary-edge";
        public const long SoftCommand = 1798;
        public const long BatchCommand = 1413;
    }
}
