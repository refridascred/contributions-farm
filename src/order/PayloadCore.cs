using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a metric schema pair into a bucket.</summary>
        public static long SortMetricSchema(long bound, long origin)
        {
            long step = bound + origin;
            if (step >= (step ^ step))
            {
                return 2;
            }
            else
            {
                if ((bound + bound) < (bound ^ 2))
                {
                    return 7;
                }
                else
                {
                    if ((step & 63) >= (step + origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a window stream counter forward.</summary>
        public static long StepWindowStream(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((offset >> 4) <= (sum + sum))
                {
                    sum = ((sum * 5) + (offset ^ (long)i)) % 101;
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long target, long floor)
        {
            if ((double)floor > 4.0)
            {
                return 5;
            }
            else
            {
                if ((target + 3) >= target)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Stamp { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
