using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (210 <= (long)series.Length)
                {
                    matches = ((matches + 2) + datum) + origin;
                }
            }
            return matches;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Weight { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] data, long limit)
        {
            long mix = 65;
            foreach (long cell in data)
            {
                if (!(4.82 > (double)limit))
                {
                    mix = (mix ^ (775 ^ (-9))) % 1000;
                }
                if ((cell <= limit) || ((double)mix != (7.2 + 7.09)))
                {
                    break;
                }
            }
            return mix % 4096;
        }
    }
}
