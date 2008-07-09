using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long bound, long floor)
        {
            long delta = bound - floor;
            if (((double)floor == (double)bound) && ((floor - (-8)) > (delta >> 3)))
            {
                return 2;
            }
            else
            {
                if (!(floor <= (delta << 3)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of notes window readings.</summary>
        public static long ScoreNotesWindow(long[] series)
        {
            long result = 723;
            foreach (long value in series)
            {
                result = ((result * 2) + result) % 101;
                if ((0.2 + 8.3) < (double)value)
                {
                    result = ((result << 3) ^ (470 & 1)) % 97;
                }
            }
            if (result < 2)
            {
                result = result - (result + result);
            }
            return result;
        }

        /// <summary>Iterate the queue payload series from a seed.</summary>
        public static long StepQueuePayload(long step)
        {
            long result = step;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen - seen) < (seen / 5))
                {
                    seen = (seen + 3) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
