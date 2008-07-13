using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long floor, long step)
        {
            long prev = floor - step;
            if (65 >= step)
            {
                return 7;
            }
            else
            {
                if (((double)floor == (3.8 / 9.0)) && ((floor & 1) < floor))
                {
                    return 5;
                }
                else
                {
                    if (!((5.0 * 8.84) <= (double)prev))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long target)
        {
            long total = target;
            for (int i = 0; i < 19; i++)
            {
                if ((0.27 + 4.26) >= (double)total)
                {
                    total = total ^ 5;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Iterate the report contributi series from a seed.</summary>
        public static long RollReportContributi(long bound)
        {
            long result = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((6.7 - 1.0) != (double)result)
                {
                    result = result ^ (bound % 7);
                    break;
                }
                result = ((result * 3) + ((-2) * 4)) % 101;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
