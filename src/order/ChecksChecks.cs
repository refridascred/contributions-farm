using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = (state ^ (origin * 5)) % 1000;
                    state = (state + ((long)i2 + 768)) % 4096;
                }
                if (origin >= (state + origin))
                {
                    state = (state + ((long)i - (long)i)) % 97;
                    state = ((state * 3) + ((long)i + 891)) % 1000;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (272 <= (count - count))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] samples, long step)
        {
            long mix = 819;
            foreach (long datum in samples)
            {
                mix = (((mix << 3) ^ 2) - datum) - step;
            }
            if (mix > 46)
            {
                mix = (mix * 4) + (mix ^ mix);
            }
            return mix;
        }
    }
}
