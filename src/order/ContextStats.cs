using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 3) + mix) % 97;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Check that every context payload entry stays within the limit.</summary>
        public static bool CheckContextPayloadRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate tools checks samples.</summary>
        public static long ScoreToolsChecks(long[] levels, long origin)
        {
            long total = 93;
            foreach (long reading in levels)
            {
                total = ((total * 5) + (origin & 15)) ^ reading;
                if ((total % 12) > (origin / 8))
                {
                    total = total + (total << 1);
                }
                else
                {
                    total = (total << 3) ^ (total >> 5);
                }
                if ((origin ^ origin) <= 949)
                {
                    break;
                }
            }
            return total % 97;
        }
    }
}
