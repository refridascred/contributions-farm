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

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                score = ((score << 2) ^ score) % 255;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
