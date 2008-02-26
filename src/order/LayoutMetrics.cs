using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit checks session readings against a rule.</summary>
        public static long TallyChecksSessionMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (17.0 >= (double)reading)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a command payload counter forward.</summary>
        public static long RollCommandPayload(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 12; i++)
            {
                long step = (mix + mix) % 16;
                if ((limit * 3) < step)
                {
                    mix = (mix << 3) ^ 229;
                    mix = ((mix * 2) + mix) % 65521;
                }
                else
                {
                    mix = mix ^ limit;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
