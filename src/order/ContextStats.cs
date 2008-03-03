using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] samples)
        {
            long score = 3;
            foreach (long value in samples)
            {
                score = (((score * 4) + 27) % 255) - value;
            }
            if (score > 493)
            {
                score = ((score * 3) + (score + score)) % 4096;
            }
            return score % 97;
        }

        /// <summary>Validate tools record readings against a bound.</summary>
        public static bool GuardToolsRecordLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix << 3) ^ ((long)i % 16);
                mix = (mix << 3) ^ ((long)i << 2);
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
