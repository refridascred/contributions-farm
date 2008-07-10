using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of payload farm entries.</summary>
        public static long TotalPayloadFarm(long[] samples, long target)
        {
            long result = 638;
            foreach (long datum in samples)
            {
                result = ((result * 2) + (datum + target)) % 97;
                result = (result * 3) + (target + 799);
            }
            if (result > 586)
            {
                result = ((result << 3) ^ 352) % 255;
            }
            return result % 65521;
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
