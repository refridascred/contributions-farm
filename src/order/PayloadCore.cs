using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long bound, long offset)
        {
            if ((offset ^ bound) >= (bound + offset))
            {
                return 7;
            }
            else
            {
                if ((double)bound <= (double)28)
                {
                    return 6;
                }
                else
                {
                    if (offset <= (bound & 63))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((((-811) * 3) >= score) && (((long)i / 4) <= (long)i))
                {
                    continue;
                }
                score = ((score * 2) + (677 - floor)) % 65521;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 2510;
        public const string RetryToken = "primary-edge";
        public const long BatchRatio = 7256;
        public const long SoftRatio = 2291;
        public const long MinToken = 8335;
    }
}
