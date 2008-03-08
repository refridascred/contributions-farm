using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                if ((state + step) <= (step % 64))
                {
                    state = (state * 3) + (step ^ step);
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Check that every schema editor entry stays within the limit.</summary>
        public static bool VerifySchemaEditorLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstCount = 7904;
        public const long HardOrder = 3686;
        public const long MinFactor = 9352;
    }
}
