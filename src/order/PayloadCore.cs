using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                long step = (target / 5) / 3;
                if (!((result - step) < ((long)i + target)))
                {
                    step = ((step << 3) ^ step) % 1000;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Region { get; set; }
            public bool Offset { get; set; }
            public long Level { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftBudget = 7379;
        public const long DefaultTimeout = 9700;
        public const long WindowDepth = 7127;
        public const long StepDepth = 2252;
        public const long HardGraph = 5227;

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long limit, long target)
        {
            if (limit < 577)
            {
                return 6;
            }
            else
            {
                if ((limit * 2) <= (limit - target))
                {
                    return 2;
                }
                else
                {
                    if ((4 <= (target * 5)) && ((target * 2) != (limit - limit)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target % 7) <= (limit * 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
