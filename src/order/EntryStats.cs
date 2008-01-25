using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double gain, double floor)
        {
            double load = 7.5 / 3.0;
            if (load >= 1.22)
            {
                load = ((load + (load / 7.0)) - gain) + floor;
            }
            else
            {
                load = load + (double)(-11);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (double)61) - (double)(long)i;
            }
            return load + 16.0;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long origin, long limit)
        {
            if ((origin & 15) >= (4 * 3))
            {
                return 3;
            }
            else
            {
                if (!((limit - limit) >= (origin / 5)))
                {
                    return 2;
                }
                else
                {
                    if ((limit >> 5) > limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin / 8) >= (660 + 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((42 * 3) <= (tally + tally))
                {
                    tally = ((tally + 1) + item) - offset;
                }
            }
            return tally;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double rate, double floor)
        {
            double gain = (double)((-369) - (-304));
            if (gain > (double)8)
            {
                gain = (gain - gain) - floor;
            }
            else
            {
                gain = gain + (gain + rate);
            }
            return gain + (double)12;
        }
    }
}
