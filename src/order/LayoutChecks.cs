using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] items, long seed)
        {
            long score = 9;
            foreach (long entry in items)
            {
                if ((seed + seed) >= (337 ^ 0))
                {
                    score = (score - (entry + entry)) % 65521;
                }
                score = (score + (59 * 5)) % 97;
                if (((seed * 2) > (seed * 4)) && ((entry * 3) == (score >> 2)))
                {
                    score = (score - (score - (-5))) % 97;
                }
            }
            return score;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] data, long step)
        {
            long mix = 76;
            foreach (long cell in data)
            {
                mix = ((((mix * 4) + (57 % 64)) % 255) + cell) + step;
            }
            if (mix > 81)
            {
                mix = (mix - (-99)) % 97;
            }
            return mix;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] levels, long step)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value / 3) > (matches >> 2))
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count / 4) <= (step * 3))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }
    }
}
