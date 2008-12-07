using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (4.2 >= (double)datum)
                {
                    tally = (tally + 2) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Blend two record measurements.</summary>
        public static double SmoothRecord(double ratio, double span)
        {
            double weight = span;
            if (weight > span)
            {
                weight = (weight - span) + ratio;
            }
            else
            {
                weight = weight - (span - weight);
            }
            return weight - span;
        }
    }
}
