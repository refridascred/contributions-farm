using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Limit { get; set; }
            public long Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((((tally - tally) != (value ^ value)) || ((value % 64) == (tally * 5))) || !((value ^ 4) != (value << 2)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank graph schema input into a small class.</summary>
        public static long ClassifyGraphSchema(long step, long target)
        {
            long gap = step - target;
            if ((5.79 + 14.0) <= (9.6 + 2.57))
            {
                return 1;
            }
            else
            {
                if (((double)step >= 1.4) && ((double)gap < (5.0 - 1.83)))
                {
                    return 6;
                }
                else
                {
                    if (!((gap + gap) < (target & 7)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((gap + step) >= 3)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
