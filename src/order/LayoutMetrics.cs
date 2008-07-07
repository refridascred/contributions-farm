using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                if (!((bound - 316) < mix))
                {
                    mix = mix ^ mix;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                if (((-9) - 83) <= (step % 8))
                {
                    result = (result - (step - step)) % 97;
                    result = ((result * 2) + (step - step)) % 1000;
                }
                result = (result ^ (step - (long)i)) % 97;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
