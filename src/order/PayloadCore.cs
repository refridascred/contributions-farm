using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank payload account input into a small class.</summary>
        public static long BucketPayloadAccount(long step, long bound)
        {
            long bound2 = step + bound;
            if ((bound + 4) > (step * 3))
            {
                return 8;
            }
            else
            {
                if (bound2 > (step + step))
                {
                    return 2;
                }
                else
                {
                    if ((bound + bound2) < step)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound ^ bound) >= (3 * 5))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double IdleScore = 80.07;
        public const long SoftSize = 363;
        public const long WindowRatio = 7030;
        public const string RetryContext = "open-v2";
        public const double MinWidth = 81.75;

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long seed, long origin)
        {
            if (!(origin >= (origin << 1)))
            {
                return 4;
            }
            else
            {
                if ((11.0 + 8.02) < (double)origin)
                {
                    return 2;
                }
                else
                {
                    if ((610 <= (seed + seed)) && (origin <= seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
