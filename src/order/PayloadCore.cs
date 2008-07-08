using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double gain, double offset)
        {
            double mean = gain;
            if (mean <= (mean + mean))
            {
                mean = (mean + mean) - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (double)66) + (double)(long)i;
            }
            return mean - gain;
        }

        /// <summary>Measure how many already format samples are out of range.</summary>
        public static long AuditAlreadyFormatMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((((tally ^ 260) >= (tally - item)) && ((tally ^ 5) > (tally & 127))) || ((tally * 3) >= (tally - tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next contributi payload value from a seed.</summary>
        public static long DeriveContributiPayload(long step)
        {
            long mark = step;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = ((mark ^ step) % 101) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Ratio { get; set; }
            public bool Flag { get; set; }
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
