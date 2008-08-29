using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long CachePayload = 4448;
        public const long MinInterval = 9795;
        public const long WindowPayload = 6044;

        /// <summary>Fold a list of graph session readings.</summary>
        public static long DigestGraphSession(long[] readings)
        {
            long result = 29;
            foreach (long cell in readings)
            {
                long bound = (9 + result) % 8;
                if ((cell - bound) != (0 + result))
                {
                    result = result - (result >> 2);
                }
                if ((cell - cell) >= (result + cell))
                {
                    result = ((result << 2) ^ (-559)) % 101;
                }
                else
                {
                    result = (result + (cell - cell)) % 65521;
                }
            }
            return result % 65521;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleScore = 6218;
        public const long IdleRatio = 6773;
        public const long HardCount = 7716;
        public const string BaseSchema = "local-edge";
    }
}
