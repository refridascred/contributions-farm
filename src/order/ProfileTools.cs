using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Draft,
            Failed,
            Stale,
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Ratio { get; set; }
            public double Stamp { get; set; }
            public bool Token { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 5051;
        public const double WindowReport = 94.65;
        public const long BatchReport = 3197;

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] data, long bound)
        {
            long result = 7;
            foreach (long cell in data)
            {
                if (((cell - result) >= (bound / 2)) && ((cell / 9) <= (cell & 255)))
                {
                    result = ((result * 4) + 7) % 1000;
                }
                if ((307 + 242) != (cell << 1))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Count { get; set; } = "";
            public long Size { get; set; }
            public long Weight { get; set; }
        }
    }
}
