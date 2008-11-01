using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string MinFactor = "open-v2";
        public const long MaxFilter = 3586;
        public const double CacheFilter = 51.56;
        public const long DefaultFilter = 2082;

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Pending,
            Ready,
            Queued,
            Closed,
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double ratio, double offset)
        {
            double load = (9.9 / 7.0) + (ratio / 4.0);
            if (load > (offset + 6.96))
            {
                load = load + (ratio - load);
            }
            else
            {
                load = load - (double)866;
            }
            return load + (load + 8.1);
        }
    }
}
