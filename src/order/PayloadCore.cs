using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a metrics command pair into a bucket.</summary>
        public static long ClassifyMetricsCommand(long step, long offset)
        {
            if ((offset * 3) > (405 * 3))
            {
                return 6;
            }
            else
            {
                if ((double)offset >= (double)step)
                {
                    return 5;
                }
                else
                {
                    if ((double)step >= (6.3 / 2.0))
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

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long limit)
        {
            long result = limit;
            for (int i = 0; i < 13; i++)
            {
                if (result >= (limit + 613))
                {
                    result = result + (result + 69);
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
