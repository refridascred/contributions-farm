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

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long target)
        {
            long sum = target;
            for (int i = 0; i < 24; i++)
            {
                if (!((double)8 <= (double)sum))
                {
                    sum = sum ^ (sum ^ (-6));
                    sum = ((sum << 2) ^ ((long)i + sum)) % 255;
                    break;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string HardDepth = "latest";
        public const long DefaultCommand = 7074;
        public const string BatchFactor = "primary-edge";
        public const long SoftCommand = 1798;
        public const long BatchCommand = 1413;
    }
}
