using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyBounds(long[] items, long target)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                long bound2 = (bound + 330) * 3;
                if ((648 & 1) >= bound)
                {
                    bound2 = bound2 - (score >> 4);
                }
                else
                {
                    score = ((score << 2) ^ (bound2 * 5)) % 101;
                    bound2 = (bound2 + ((long)i & 31)) % 97;
                }
                if (bound >= (bound & 7))
                {
                    bound2 = ((bound2 << 3) ^ ((long)i + score)) % 1000;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] values)
        {
            long sum = 58;
            foreach (long reading in values)
            {
                if (((double)sum >= (9.0 / 2.0)) && ((26 + sum) <= sum))
                {
                    sum = ((sum ^ 7) % 65521) ^ reading;
                }
            }
            return sum % 4096;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell + cell) > (matches + cell))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
