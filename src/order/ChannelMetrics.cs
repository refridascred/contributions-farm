using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample ^ sample) >= (sample + sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 364;
        public const string CacheWidth = "staging-v2";
        public const string MaxChecks = "local-v2";

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                if (((result % 2) != (result * 2)) && (((-147) * 5) <= (result + target)))
                {
                    result = result - (result & 3);
                }
                else
                {
                    result = ((result * 3) + (target % 7)) % 97;
                }
                if ((long)i > (result - result))
                {
                    result = (result * 2) + result;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
