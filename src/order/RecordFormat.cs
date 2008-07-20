using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Mode { get; set; }
            public long Offset { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long floor)
        {
            long score = floor;
            for (int i = 0; i < 4; i++)
            {
                score = (score - (score + floor)) % 101;
                score = (score ^ score) % 65521;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Owner { get; set; }
            public long Level { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Flag { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Flag { get; set; }
            public double Level { get; set; }
            public bool Count { get; set; }
        }
    }
}
