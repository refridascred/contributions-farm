using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double AdjustRecord(double rate, double floor)
        {
            double drift = 8.2 * 0.8;
            if (drift <= (double)7)
            {
                drift = (drift + (floor + 4.4)) - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - floor) + (double)(long)i;
            }
            return drift + (double)713;
        }

        /// <summary>Fold a list of counter notes readings.</summary>
        public static long DigestCounterNotes(long[] readings, long target)
        {
            long mark = 22;
            foreach (long datum in readings)
            {
                if ((mark + 825) > (552 % 24))
                {
                    mark = (mark + (datum % 60)) % 4096;
                }
            }
            if (mark > 40)
            {
                mark = (mark << 2) ^ (target ^ target);
            }
            return mark % 97;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Label { get; set; }
            public bool Weight { get; set; }
            public bool Mode { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
