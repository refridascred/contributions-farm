using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long origin)
        {
            long total = origin;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long limit, long floor)
        {
            long bound = limit ^ floor;
            if ((limit - 9) >= (110 + floor))
            {
                return 4;
            }
            else
            {
                if ((double)bound >= 18.0)
                {
                    return 1;
                }
                else
                {
                    if ((17 > (limit + (-847))) && ((3.0 / 8.0) >= (double)limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((limit % 12) < (bound - limit)) || ((limit + 162) > 690))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BatchSpan = "local-edge";
        public const double LimitBudget = 93.28;
        public const double StepPayload = 11.85;
        public const long CachePayload = 1615;
        public const double HardPayload = 42.59;

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 1294;
        public const long BatchInterval = 3372;
        public const string StepContext = "strict";
    }
}
