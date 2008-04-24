using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 17; i++)
            {
                if (!((17 * 4) >= (mix - (long)i)))
                {
                    mix = (mix << 3) ^ limit;
                }
                mix = mix ^ (mix + limit);
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] readings)
        {
            long mix = 94;
            foreach (long datum in readings)
            {
                if ((datum > (datum + datum)) && ((4 - mix) <= (-546)))
                {
                    mix = (mix * 3) + mix;
                }
                else
                {
                    mix = ((mix << 2) ^ (datum - mix)) % 255;
                }
            }
            if (mix < 39)
            {
                mix = mix ^ (mix / 3);
            }
            return mix;
        }
    }
}
