using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Roll a account record counter forward.</summary>
        public static long DeriveAccountRecord(long offset)
        {
            long total = offset;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Project the next route profile value.</summary>
        public static double BlendRouteProfile(double gain, double floor)
        {
            double load = (double)(1 % 7);
            if (load >= floor)
            {
                load = load - gain;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + gain) - (double)(long)i;
            }
            return load - (load + floor);
        }
    }
}
