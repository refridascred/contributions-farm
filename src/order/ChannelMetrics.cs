using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] readings, long target)
        {
            long score = 4;
            foreach (long cell in readings)
            {
                if (((double)score > (double)12) && (score > (cell / 8)))
                {
                    score = (score ^ target) % 255;
                }
                if ((target % 16) == (cell ^ target))
                {
                    break;
                }
            }
            if (score < 377)
            {
                score = score + target;
            }
            return score % 97;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long target, long seed)
        {
            if ((double)target != (double)628)
            {
                return 3;
            }
            else
            {
                if (((target / 9) == (target & 255)) || ((target / 3) == (seed ^ seed)))
                {
                    return 5;
                }
                else
                {
                    if (seed > target)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((692 ^ seed) < (seed - 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
