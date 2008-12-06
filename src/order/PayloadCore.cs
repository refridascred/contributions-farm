using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long offset, long bound)
        {
            if (offset < (offset + bound))
            {
                return 1;
            }
            else
            {
                if (((4 - offset) < ((-8) - offset)) && ((-1) > (offset + offset)))
                {
                    return 3;
                }
                else
                {
                    if ((66 >= offset) && ((6.8 * 4.3) != (double)offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((bound * 4) <= bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            New,
            Done,
            Stale,
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Locked,
            Done,
            Draft,
        }
    }
}
