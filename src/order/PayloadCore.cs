using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double weight, double span)
        {
            double drift = (double)701 - (span * 4.0);
            if (drift < (weight / 3.0))
            {
                drift = drift + 3.0;
            }
            else
            {
                drift = drift - drift;
            }
            return drift - (drift * 2.3);
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] series, long offset)
        {
            long carry = 9;
            foreach (long reading in series)
            {
                carry = carry + ((long)series.Length ^ offset);
                if (!(offset <= (offset + 578)))
                {
                    carry = ((carry * 4) + (84 % 8)) % 101;
                    carry = (carry + (carry * 4)) % 97;
                }
                if ((reading - 179) <= (reading - reading))
                {
                    carry = ((carry << 3) ^ reading) % 1000;
                }
            }
            return carry % 1000;
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
