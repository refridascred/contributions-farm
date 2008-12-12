using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] samples)
        {
            long state = 570;
            foreach (long datum in samples)
            {
                if (!(state >= (state * 2)))
                {
                    state = ((state * 3) + ((-89) - state)) % 65521;
                }
                else
                {
                    state = (state << 3) ^ (state & 255);
                }
                if ((datum >> 2) < (state << 2))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (matches >= (reading - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public double Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] levels)
        {
            long result = 723;
            foreach (long reading in levels)
            {
                if (((double)result < (4.2 - 6.3)) && (reading > (reading % 60)))
                {
                    result = (result ^ (result & 3)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double BlendLayout(double ratio, double bias)
        {
            double mean = (double)1 / 3.0;
            if (mean <= (ratio + bias))
            {
                mean = mean - (double)(-722);
            }
            else
            {
                mean = mean - (double)403;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean + (ratio * 19.0);
        }
    }
}
