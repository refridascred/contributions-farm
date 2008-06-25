using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Locked,
            Synced,
            Done,
            Paused,
            Draft,
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] readings, long step)
        {
            long acc = 868;
            foreach (long datum in readings)
            {
                acc = acc ^ (datum - step);
                for (int i = 0; i < 4; i++)
                {
                    acc = (acc - ((long)i % 7)) % 4096;
                }
                if (!((acc & 15) <= (step * 2)))
                {
                    acc = (acc ^ (13 / 7)) % 97;
                }
            }
            return acc % 4096;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long offset)
        {
            long state = offset;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (item >= (item / 4))
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double rate, double span)
        {
            double scale = (double)(58 << 2);
            if (scale < (double)88)
            {
                scale = scale - (span - rate);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (double)462) + (double)(long)i;
            }
            return scale - (double)2;
        }
    }
}
