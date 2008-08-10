using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double bias, double floor)
        {
            double load = floor;
            if (load > floor)
            {
                load = load - (load - bias);
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - load) - (double)(long)i;
            }
            return load - (bias + bias);
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long bound, long seed)
        {
            long offset = bound ^ seed;
            if ((989 + offset) <= (bound / 8))
            {
                return 0;
            }
            else
            {
                if ((offset * 2) <= (seed % 24))
                {
                    return 1;
                }
                else
                {
                    if ((bound ^ seed) < (bound << 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 8112;
        public const long HardChannel = 7238;
        public const long IdleRatio = 1672;
        public const string StepInterval = "cached";
    }
}
