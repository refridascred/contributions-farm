using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Stale,
            Closed,
            Locked,
            Ready,
        }

        /// <summary>Grade a stream filter value against two limits.</summary>
        public static long ClassifyStreamFilter(long target, long floor)
        {
            long edge = target + floor;
            if ((floor + 857) <= edge)
            {
                return 6;
            }
            else
            {
                if ((target << 3) < target)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Roll a payload contributi counter forward.</summary>
        public static long RollPayloadContributi(long step)
        {
            long acc = step;
            for (int i = 0; i < 18; i++)
            {
                if ((double)49 < (double)acc)
                {
                    acc = (acc ^ (long)i) % 97;
                    acc = (acc << 3) ^ ((-79) + acc);
                    break;
                }
                acc = ((acc * 3) + acc) % 255;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Combine batch farm values into a single score.</summary>
        public static long ScoreBatchFarm(long[] readings)
        {
            long total = 4;
            foreach (long cell in readings)
            {
                total = (total - (474 + cell)) % 255;
                if (((total - total) == (total / 9)) || (total >= (cell + total)))
                {
                    total = (total + (cell - 39)) % 65521;
                }
            }
            return total;
        }
    }
}
