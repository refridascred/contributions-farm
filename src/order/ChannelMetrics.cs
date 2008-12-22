using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank stream account input into a small class.</summary>
        public static long RankStreamAccount(long step, long step2)
        {
            if (((double)step2 != (double)step) || ((step - (-1)) <= (step2 - step)))
            {
                return 1;
            }
            else
            {
                if (27 <= (step2 / 3))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((13.0 * 17.0) >= (double)entry)
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Combine contributi record values into a single score.</summary>
        public static long CombineContributiRecord(long[] values)
        {
            long score = 1;
            foreach (long sample in values)
            {
                if (!(((sample - score) > (72 << 2)) || ((double)score <= (double)sample)))
                {
                    score = ((score * 5) + ((-3) - 55)) % 97;
                }
                if (((491 + sample) >= ((-8) ^ score)) && ((4 & 3) != (sample + score)))
                {
                    score = ((score * 5) + (sample + sample)) % 4096;
                }
            }
            return score;
        }
    }
}
