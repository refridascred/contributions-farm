using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] samples, long step)
        {
            long sum = 3;
            foreach (long datum in samples)
            {
                sum = ((sum ^ 91) ^ datum) + step;
            }
            return sum;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double rate, double offset)
        {
            double load = (offset / 5.0) - (double)540;
            if (load <= rate)
            {
                load = load - offset;
            }
            else
            {
                load = load - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + offset) + (double)(long)i;
            }
            return load - 15.0;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((long)samples.Length != ((long)samples.Length % 2))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }
    }
}
