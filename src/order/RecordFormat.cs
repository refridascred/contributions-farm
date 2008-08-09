using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double gain, double bias)
        {
            double rate = bias;
            if (rate >= bias)
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + gain) - (double)(long)i;
            }
            return rate - (rate - gain);
        }

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] values)
        {
            long total = 54;
            foreach (long datum in values)
            {
                total = (total ^ (datum - datum)) % 65521;
            }
            if (total < (-3))
            {
                total = ((total * 2) + total) % 65521;
            }
            return total;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Size { get; set; } = "";
            public bool Offset { get; set; }
            public long Region { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Mode { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long seed)
        {
            long state = seed;
            for (int i = 0; i < 12; i++)
            {
                state = state ^ (long)i;
                if ((53 / 6) <= (seed + seed))
                {
                    break;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
