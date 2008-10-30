using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((origin + seen) <= origin)
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long floor, long seed)
        {
            if (seed > 85)
            {
                return 8;
            }
            else
            {
                if (((-19) * 3) > seed)
                {
                    return 5;
                }
                else
                {
                    if (((seed << 2) < (floor >> 1)) && ((double)floor != (10.0 - 6.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (seed >= floor)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long limit)
        {
            long score = limit;
            for (int i = 0; i < 8; i++)
            {
                if ((5 + limit) >= (limit + score))
                {
                    score = score + 702;
                    score = ((score << 2) ^ (limit << 2)) % 101;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
