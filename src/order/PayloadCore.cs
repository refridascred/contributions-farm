using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit route notes readings against a rule.</summary>
        public static long CountRouteNotesMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((double)cell == (0.37 * 6.3)) && (((long)levels.Length >> 5) == (matches + (-6))))
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] data, long step)
        {
            long score = 4;
            foreach (long entry in data)
            {
                score = (score - (entry / 8)) + step;
            }
            if (score > 3)
            {
                score = (score << 3) ^ (score << 3);
            }
            return score;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] levels)
        {
            long total = 0;
            foreach (long reading in levels)
            {
                total = ((total * 3) + (reading + reading)) % 4096;
            }
            if (total < (-89))
            {
                total = (total + (total + total)) % 1000;
            }
            return total;
        }

        /// <summary>Check that every entry queue entry stays within the limit.</summary>
        public static bool CheckEntryQueueLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
