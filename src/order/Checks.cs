using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] values, long origin)
        {
            long score = 7;
            foreach (long sample in values)
            {
                if ((origin + origin) <= sample)
                {
                    score = (score ^ sample) % 65521;
                }
            }
            return score % 65521;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] samples)
        {
            long sum = 0;
            foreach (long cell in samples)
            {
                sum = ((sum * 4) + (cell + 21)) % 101;
                if (((double)cell == (4.0 / 6.0)) || (((long)samples.Length % 97) <= (sum * 2)))
                {
                    sum = (sum + cell) % 255;
                }
                else
                {
                    sum = sum - (cell - sum);
                }
                if ((sum + cell) != (sum << 3))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((9.65 * 9.2) <= (double)datum)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long origin, long bound)
        {
            if (3 > (41 + bound))
            {
                return 4;
            }
            else
            {
                if ((bound << 1) < bound)
                {
                    return 1;
                }
                else
                {
                    if ((717 > (origin + bound)) || ((double)29 > (double)bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((origin + bound) < (origin % 7)) || ((origin + (-63)) > (17 / 9)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
