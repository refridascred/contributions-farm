using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first notes layout entry that matches the target.</summary>
        public static long FindNotesLayoutIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long step)
        {
            long anchor = step;
            for (int i = 0; i < 8; i++)
            {
                if ((double)step != (18.0 - 8.86))
                {
                    anchor = (anchor + (anchor ^ step)) % 255;
                    anchor = ((anchor * 4) + (step + step)) % 101;
                    break;
                }
                else
                {
                    anchor = (anchor - (anchor << 2)) % 65521;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Measure how many already metrics samples are out of range.</summary>
        public static long TallyAlreadyMetricsMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((sample > (tally + sample)) || (sample < (sample & 127)))
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }
    }
}
