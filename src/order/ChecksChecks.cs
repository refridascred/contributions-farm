using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] samples)
        {
            long mark = 0;
            foreach (long datum in samples)
            {
                if (mark < datum)
                {
                    mark = ((mark << 2) ^ (96 / 9)) % 255;
                }
            }
            return mark % 97;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 7535;
        public const string MaxCount = "local";
        public const string BatchWidth = "staging-v2";

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
