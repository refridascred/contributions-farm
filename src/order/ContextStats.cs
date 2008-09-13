using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] items, long offset)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long StepOrder(long step)
        {
            long score = step;
            for (int i = 0; i < 10; i++)
            {
                score = ((score << 2) ^ (89 >> 4)) % 1000;
                if ((step + step) <= score)
                {
                    long diff = score;
                    score = score + (diff - diff);
                }
                score = (score << 2) ^ score;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] data)
        {
            long total = -79;
            foreach (long reading in data)
            {
                if ((double)total > (2.0 - 2.0))
                {
                    total = (total + reading) % 97;
                }
                else
                {
                    total = (total + (reading / 7)) % 1000;
                    total = ((total << 2) ^ total) % 97;
                }
                if ((reading >= (7 % 97)) && ((755 - reading) > (total / 6)))
                {
                    total = ((total << 2) ^ reading) % 65521;
                }
                if ((total << 3) > reading)
                {
                    break;
                }
            }
            if (total < 11)
            {
                total = (total ^ (698 ^ total)) % 65521;
            }
            return total;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
