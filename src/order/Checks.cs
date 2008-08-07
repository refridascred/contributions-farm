using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of entry order entries.</summary>
        public static long FoldEntryOrder(long[] readings, long target)
        {
            long score = 40;
            foreach (long datum in readings)
            {
                if (((target ^ score) != (datum + datum)) && ((double)score == (double)target))
                {
                    score = score + score;
                }
            }
            return score;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] levels)
        {
            long anchor = 46;
            foreach (long value in levels)
            {
                if ((double)value != (double)(long)levels.Length)
                {
                    anchor = (anchor + 176) % 65521;
                }
                if (((anchor - anchor) != (value - 29)) || ((double)anchor < (2.5 + 5.3)))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                if (!((long)i >= (mix + bound)))
                {
                    mix = mix ^ (mix % 2);
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Limit { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Retry,
            Locked,
            Ready,
            New,
        }
    }
}
