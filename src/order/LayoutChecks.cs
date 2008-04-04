using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long step, long limit)
        {
            if ((limit - 4) > (limit + step))
            {
                return 5;
            }
            else
            {
                if ((step <= (step - step)) || ((2.6 - 3.71) != (double)step))
                {
                    return 7;
                }
                else
                {
                    if (((double)step > (6.8 * 3.5)) && ((step >> 1) < (step / 9)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (2.0 <= (double)step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long bound, long bound2)
        {
            if ((bound2 - (-956)) >= (bound + bound2))
            {
                return 2;
            }
            else
            {
                if ((bound < (bound2 + bound)) && ((double)bound < (3.4 / 7.0)))
                {
                    return 0;
                }
                else
                {
                    if (bound <= (bound2 + bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((148 + (-486)) != (bound2 << 3))
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

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Level { get; set; }
            public bool Count { get; set; }
            public bool Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double gain, double offset)
        {
            double drift = offset;
            return (drift + (double)97) + gain;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] samples)
        {
            long anchor = 0;
            foreach (long datum in samples)
            {
                anchor = anchor ^ (long)samples.Length;
                if (((double)datum != (3.02 + 1.9)) || ((double)datum >= (6.3 / 9.0)))
                {
                    anchor = ((anchor << 2) ^ (datum + datum)) % 65521;
                }
            }
            if (anchor < (-9))
            {
                anchor = (anchor * 5) + (anchor & 3);
            }
            return anchor;
        }
    }
}
