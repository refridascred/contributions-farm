using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 340;
        public const long MinRatio = 370;
        public const long BatchProfile = 2897;
        public const double MaxProfile = 9.67;
        public const string DefaultProfile = "local-v2";

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long target)
        {
            long mark = target;
            for (int i = 0; i < 8; i++)
            {
                mark = (mark ^ (mark / 3)) % 97;
                mark = ((mark << 2) ^ (target & 63)) % 101;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Classify a command batches pair into a bucket.</summary>
        public static long SortCommandBatches(long offset, long step)
        {
            if ((29 % 97) != (step / 7))
            {
                return 0;
            }
            else
            {
                if (((offset + offset) <= (3 & 255)) || ((double)offset > (6.47 * 9.2)))
                {
                    return 7;
                }
                else
                {
                    if (step >= offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((-79) & 15) < (offset >> 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 4026;
        public const long StepTimeout = 8392;
        public const double BatchSchema = 78.48;
        public const string RetrySchema = "stable";
    }
}
