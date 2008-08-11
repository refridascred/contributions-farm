using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (reading <= (matches * 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] readings, long seed)
        {
            long sum = 53;
            foreach (long item in readings)
            {
                sum = ((sum ^ (sum + seed)) % 97) + item;
            }
            if (sum < (-5))
            {
                sum = (sum + (76 << 2)) % 65521;
            }
            return sum % 65521;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long offset, long target)
        {
            long gap = offset + target;
            if (((double)offset <= (1.27 * 7.7)) || ((gap - gap) == (target * 4)))
            {
                return 5;
            }
            else
            {
                if (((offset >> 5) >= (gap - gap)) || ((double)offset == (6.9 - 7.2)))
                {
                    return 1;
                }
                else
                {
                    if (!(target >= (86 & 7)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((932 - offset) < gap) && ((offset - offset) >= (665 - 9)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long limit)
        {
            long score = limit;
            for (int i = 0; i < 10; i++)
            {
                score = ((score << 2) ^ score) % 65521;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (15.0 <= (double)value)
                {
                    count = (count + 2) + limit;
                }
            }
            return count;
        }
    }
}
