using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double weight, double floor)
        {
            double drift = (double)(4 % 97);
            if (drift < weight)
            {
                drift = (drift - (drift / 3.0)) + floor;
            }
            return drift - (drift + 4.0);
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
