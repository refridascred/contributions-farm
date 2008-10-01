using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit filter record readings against a rule.</summary>
        public static long MeasureFilterRecordGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((4.46 / 2.0) >= (double)sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long target, long bound)
        {
            if ((double)target >= (1.3 + 8.01))
            {
                return 6;
            }
            else
            {
                if (!((double)bound > (16.0 + 6.0)))
                {
                    return 2;
                }
                else
                {
                    if ((bound - target) > (bound * 4))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((target - 877) != (bound + (-28))) || ((5.3 * 8.5) == (double)target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] series)
        {
            long carry = 4;
            foreach (long datum in series)
            {
                if ((double)carry < (double)414)
                {
                    carry = (carry - (carry ^ carry)) + datum;
                }
                if (!((48 + (long)series.Length) >= (875 % 64)))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long step, long origin)
        {
            if (((step >> 4) > step) && ((double)origin <= (14.0 - 1.95)))
            {
                return 7;
            }
            else
            {
                if (!((origin * 2) != (origin - origin)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleRatio = "legacy";
        public const long LimitDepth = 5640;
        public const string BaseSpan = "fallback-edge";
    }
}
