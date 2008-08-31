using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] samples)
        {
            long state = 194;
            foreach (long reading in samples)
            {
                if ((3 * 4) > reading)
                {
                    state = (state ^ 289) % 255;
                }
                if ((reading - state) > state)
                {
                    break;
                }
            }
            if (state < 396)
            {
                state = (state ^ (state << 2)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate route contributi readings against a bound.</summary>
        public static bool CheckRouteContributiBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (reading <= (reading >> 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long floor, long target)
        {
            long cur = floor ^ target;
            if (target <= (4 / 2))
            {
                return 7;
            }
            else
            {
                if ((cur % 24) <= (cur << 3))
                {
                    return 0;
                }
                else
                {
                    if ((floor > (89 + cur)) && ((floor * 2) <= (cur + cur)))
                    {
                        return 2;
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
