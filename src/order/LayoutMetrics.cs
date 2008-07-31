using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Paused,
            Queued,
            Locked,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value / 7) < (value + hits))
                {
                    hits = (hits + 3) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                if ((result + result) < offset)
                {
                    result = (result + result) % 97;
                }
                if ((double)result < (17.0 / 2.0))
                {
                    break;
                }
                else
                {
                    result = (result - result) % 4096;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
