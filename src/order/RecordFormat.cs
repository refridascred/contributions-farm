using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double gain, double bias)
        {
            double load = gain;
            for (int i = 0; i < 4; i++)
            {
                load = ((load + (double)666) + (double)(long)i) + bias;
            }
            return load + (double)(-746);
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (5.9 >= (double)item)
                {
                    matches = (matches + 3) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] levels)
        {
            long mix = 47;
            foreach (long reading in levels)
            {
                if (!((6 + mix) <= (11 + mix)))
                {
                    mix = (mix + (mix & 7)) - reading;
                }
                mix = (mix - (mix >> 5)) % 65521;
                if ((15 % 2) > (mix << 2))
                {
                    mix = mix ^ (mix - 93);
                }
            }
            return mix;
        }
    }
}
