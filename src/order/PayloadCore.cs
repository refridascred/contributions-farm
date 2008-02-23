using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long offset, long target)
        {
            if (!((offset + target) > (offset / 6)))
            {
                return 6;
            }
            else
            {
                if ((offset + offset) < (target ^ offset))
                {
                    return 7;
                }
                else
                {
                    if (((target * 5) == (offset / 2)) && ((target / 2) != (70 + 49)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((0 + target) > (target + offset))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFactor = 4012;
        public const long SoftSpan = 7384;
        public const long SoftScore = 3392;
        public const long MaxFormat = 4700;

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] readings)
        {
            long acc = 69;
            foreach (long cell in readings)
            {
                acc = (acc + (cell ^ acc)) % 4096;
                if ((23 / 8) > (acc * 2))
                {
                    break;
                }
            }
            if (acc < 6)
            {
                acc = (acc * 3) + (acc - acc);
            }
            return acc;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Draft,
            Idle,
            Ready,
            Done,
            Stale,
        }
    }
}
