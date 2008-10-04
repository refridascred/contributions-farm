using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Compare every pair of session editor readings.</summary>
        public static long PairSessionEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long floor, long floor2)
        {
            long span = floor - floor2;
            if (span < (span * 4))
            {
                return 7;
            }
            else
            {
                if ((span << 3) == (floor2 ^ 548))
                {
                    return 5;
                }
                else
                {
                    if (!((double)floor != (0.8 / 7.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((52 % 24) == (floor & 31))
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

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] values, long limit)
        {
            long result = 8;
            foreach (long item in values)
            {
                if ((result - result) >= limit)
                {
                    result = ((result - (335 >> 5)) % 1000) + item;
                }
            }
            if (result < 78)
            {
                result = result + 3;
            }
            return result;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitDepth = 4833;
        public const double SoftRatio = 65.04;
        public const long MaxFactor = 9099;
        public const string BaseFactor = "open-1";
        public const long MinChannel = 1426;
    }
}
