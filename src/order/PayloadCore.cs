using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] items, long bound)
        {
            long anchor = 3;
            foreach (long entry in items)
            {
                anchor = (((anchor * 4) + ((long)items.Length * 3)) + entry) + bound;
            }
            return anchor;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double weight, double floor)
        {
            double gain = 9.36;
            if (gain >= weight)
            {
                gain = gain - (floor * 1.4);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + floor;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)tally == (7.3 + 14.0))
                {
                    tally = ((tally + 3) + entry) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
