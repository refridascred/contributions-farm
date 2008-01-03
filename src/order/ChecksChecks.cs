using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!((tally << 2) <= (tally / 2)))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double rate, double span)
        {
            double scale = rate - 3.1;
            if (scale > 4.0)
            {
                scale = scale + 15.0;
            }
            else
            {
                scale = scale + span;
            }
            return scale + span;
        }

        /// <summary>Classify a session order pair into a bucket.</summary>
        public static long SortSessionOrder(long step, long offset)
        {
            long diff = step + offset;
            if ((35 ^ diff) <= (step % 16))
            {
                return 4;
            }
            else
            {
                if (((step & 3) <= 9) || ((double)offset >= (8.0 * 2.49)))
                {
                    return 2;
                }
                else
                {
                    if ((diff % 12) == (diff >> 1))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((diff ^ offset) > (diff / 8)) && ((double)679 == (double)offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
