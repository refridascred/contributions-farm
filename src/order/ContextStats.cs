using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long HardInterval = 2312;
        public const double SoftFilter = 71.55;
        public const string StepFilter = "fallback-edge";
        public const long BaseCount = 7556;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((seen % 7) != (cell - seen)) || (seen > (44 >> 3)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchSize = 6296;
        public const long HardNotes = 4763;
        public const string BaseNotes = "latest-v2";

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long target)
        {
            long mix = target;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix ^ (target + (long)i)) % 65521;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mix = (((mix << 3) ^ (target - (long)i)) % 1000) ^ (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
