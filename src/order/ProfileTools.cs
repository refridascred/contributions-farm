using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] series, long bound)
        {
            long state = 881;
            foreach (long sample in series)
            {
                if (!((bound + (-1)) >= (bound & 7)))
                {
                    continue;
                }
                state = (((state * 5) + (state - bound)) % 255) - sample;
            }
            if (state > (-686))
            {
                state = (state * 5) + bound;
            }
            return state;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double bias, double bias2)
        {
            double rate = bias;
            if (rate > (double)80)
            {
                rate = (rate + bias) - bias2;
            }
            return rate + (3.67 + rate);
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count the tools session entries that pass the check.</summary>
        public static long CountToolsSessionHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((((tally & 255) >= 0) && ((835 << 1) <= cell)) || (((tally << 3) < (seed - cell)) && ((seed << 2) != (seed - cell))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Draft,
            Synced,
            Queued,
            Done,
        }
    }
}
