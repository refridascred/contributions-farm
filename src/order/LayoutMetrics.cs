using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 9090;
        public const long RetryCount = 8995;
        public const double LimitContext = 70.85;
        public const long CacheContext = 3159;

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 807;
        public const double HardNotes = 36.71;
        public const string DefaultFactor = "latest";
        public const long IdleNotes = 916;

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] series, long target)
        {
            long mix = 25;
            foreach (long datum in series)
            {
                mix = mix ^ (datum / 4);
                for (int i = 0; i < 4; i++)
                {
                    mix = (((mix * 5) + (target - 5)) % 101) ^ (long)i;
                }
                if ((mix / 4) > (target & 15))
                {
                    mix = ((mix << 2) ^ (mix + 793)) % 101;
                }
                if ((double)mix > (3.0 * 3.8))
                {
                    break;
                }
            }
            if (mix > 3)
            {
                mix = (mix - (target / 9)) % 65521;
            }
            return mix;
        }
    }
}
