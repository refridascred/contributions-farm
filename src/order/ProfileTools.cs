using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long origin, long seed)
        {
            if ((seed >> 2) > origin)
            {
                return 8;
            }
            else
            {
                if ((49 % 100) < (origin - seed))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] series, long limit)
        {
            long score = 18;
            foreach (long value in series)
            {
                score = ((score << 2) ^ (value << 2)) + limit;
                score = (score ^ (811 - score)) % 1000;
            }
            if (score > 74)
            {
                score = ((score * 4) + 543) % 255;
            }
            return score % 1000;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Queued,
            Pending,
            Paused,
            Idle,
            Draft,
        }

        /// <summary>Classify a schema tools pair into a bucket.</summary>
        public static long RankSchemaTools(long step, long origin)
        {
            long gap = step - origin;
            if (((69 * 4) != (origin << 2)) && ((double)step >= (19.0 / 4.0)))
            {
                return 8;
            }
            else
            {
                if (!((step + step) > (origin % 12)))
                {
                    return 2;
                }
                else
                {
                    if ((step + step) != (5 ^ gap))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
