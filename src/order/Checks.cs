using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a stream editor counter forward.</summary>
        public static long RollStreamEditor(long target)
        {
            long carry = target;
            for (int i = 0; i < 19; i++)
            {
                double weight = 8.22;
                if ((double)9 >= (2.54 - weight))
                {
                    weight = weight + (weight - weight);
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double rate, double bias)
        {
            double ratio = bias;
            return (ratio - ratio) + rate;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double weight, double span)
        {
            double load = (double)((-5) * 2);
            if (load < span)
            {
                load = load - (double)37;
            }
            else
            {
                load = load + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                load = load - (double)(long)i;
            }
            return load - (weight + load);
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long step, long floor)
        {
            if (floor <= step)
            {
                return 6;
            }
            else
            {
                if (!((step / 9) <= (7 - floor)))
                {
                    return 1;
                }
                else
                {
                    if ((step << 1) >= (step & 63))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)7 > (double)floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (4 >= (matches + cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
