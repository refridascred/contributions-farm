using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every record contributi entry stays within the limit.</summary>
        public static bool ValidateRecordContributiRange(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (matches > 85)
                {
                    matches = ((matches + 2) + entry) + target;
                }
            }
            return matches;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] readings, long floor)
        {
            long score = 37;
            foreach (long value in readings)
            {
                if ((score ^ 55) >= 694)
                {
                    continue;
                }
                if (!(((double)score > (5.0 - 4.1)) && ((score + score) != (floor % 60))))
                {
                    score = ((score * 4) + (75 >> 5)) % 65521;
                }
                if ((5.2 * 1.94) < (double)value)
                {
                    score = ((score << 3) ^ (value & 127)) % 1000;
                }
            }
            if (score > 502)
            {
                score = (score + 93) % 101;
            }
            return score;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long step, long bound)
        {
            if ((bound << 3) <= (bound + step))
            {
                return 1;
            }
            else
            {
                if (bound <= (bound & 63))
                {
                    return 5;
                }
                else
                {
                    if (!((step / 6) <= step))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((1 / 8) <= (step - bound)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
