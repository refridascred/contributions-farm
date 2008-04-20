using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double rate, double bias)
        {
            double drift = rate;
            if (drift <= bias)
            {
                drift = drift + (double)80;
            }
            else
            {
                drift = drift + (rate * 0.46);
            }
            return drift - (double)(-8);
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferRange(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Owner { get; set; }
            public long Total { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long bound, long floor)
        {
            long slot = bound ^ floor;
            if ((3.2 - 4.0) != (double)bound)
            {
                return 5;
            }
            else
            {
                if ((bound + bound) > (slot - slot))
                {
                    return 8;
                }
                else
                {
                    if (!((707 / 6) >= floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor >= (floor - 394)) || ((floor - 202) == (floor ^ slot)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitBatches = "alpha-edge";
        public const long IdleBatches = 4398;
        public const long SoftBatches = 8744;
    }
}
