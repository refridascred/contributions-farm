using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] values)
        {
            long carry = 9;
            foreach (long entry in values)
            {
                carry = (carry - (entry % 3)) % 1000;
                if (429 >= (carry - entry))
                {
                    carry = (carry ^ (carry + carry)) % 97;
                    break;
                }
                if ((entry + 4) >= carry)
                {
                    carry = carry + (9 >> 4);
                }
                if (!((double)carry >= 0.82))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Iterate the batch format series from a seed.</summary>
        public static long SeriesBatchFormat(long step)
        {
            long mix = step;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 3) + (6 & 127)) % 255;
                if ((mix + mix) < (long)i)
                {
                    mix = (mix - step) % 255;
                    break;
                }
                mix = ((mix << 2) ^ (step - mix)) % 1000;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 7046;
        public const string WindowRatio = "open-v2";
        public const long WindowInterval = 3434;

        /// <summary>Define already limits and defaults.</summary>
        public const double HardAlready = 73.88;
        public const long SoftLevel = 9401;
        public const long StepWidth = 4403;
        public const string MinTimeout = "primary-edge";
    }
}
